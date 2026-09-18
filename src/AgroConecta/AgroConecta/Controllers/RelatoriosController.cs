using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgroConecta.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace AgroConecta.Controllers
{
    public class RelatoriosController : BaseController
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RelatoriosController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var relatorios = _context.Relatorios.Include(r => r.Propriedade);
            return View(await relatorios.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var relatorio = await _context.Relatorios
                .Include(r => r.Propriedade)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio == null) return NotFound();

            return View(relatorio);
        }

        public IActionResult Create(int? propriedadeId)
        {
            ViewData["PropriedadeId"] = new SelectList(
                _context.Propriedades,
                "Id",
                "Nome",
                propriedadeId
            );

            var relatorio = new Relatorio();

            if (propriedadeId.HasValue)
            {
                relatorio.PropriedadeId = propriedadeId.Value;
            }

            return View(relatorio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Relatorio relatorio, IFormFile? Imagem)
        {
            if (Imagem != null && Imagem.Length > 0)
            {
                relatorio.ImagemPath = await SalvarImagem(Imagem);
            }

            relatorio.CriadoEm = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(relatorio);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["PropriedadeId"] = new SelectList(
                _context.Propriedades,
                "Id",
                "Nome",
                relatorio.PropriedadeId
            );

            return View(relatorio);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var relatorio = await _context.Relatorios.FindAsync(id);

            if (relatorio == null) return NotFound();

            ViewData["PropriedadeId"] = new SelectList(
                _context.Propriedades,
                "Id",
                "Nome",
                relatorio.PropriedadeId
            );

            return View(relatorio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Relatorio relatorio, IFormFile? Imagem)
        {
            if (id != relatorio.Id) return NotFound();

            var relatorioExistente = await _context.Relatorios.AsNoTracking()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (relatorioExistente == null) return NotFound();

            if (Imagem != null && Imagem.Length > 0)
            {
                relatorio.ImagemPath = await SalvarImagem(Imagem);
            }
            else
            {
                relatorio.ImagemPath = relatorioExistente.ImagemPath;
            }

            relatorio.CriadoEm = relatorioExistente.CriadoEm;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioExists(relatorio.Id)) return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["PropriedadeId"] = new SelectList(
                _context.Propriedades,
                "Id",
                "Nome",
                relatorio.PropriedadeId
            );

            return View(relatorio);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var relatorio = await _context.Relatorios
                .Include(r => r.Propriedade)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (relatorio == null) return NotFound();

            return View(relatorio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var relatorio = await _context.Relatorios.FindAsync(id);

            if (relatorio != null)
            {
                _context.Relatorios.Remove(relatorio);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private async Task<string> SalvarImagem(IFormFile imagem)
        {
            string pastaUploads = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", "relatorios");

            if (!Directory.Exists(pastaUploads))
            {
                Directory.CreateDirectory(pastaUploads);
            }

            string nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(imagem.FileName);
            string caminhoCompleto = Path.Combine(pastaUploads, nomeArquivo);

            using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
            {
                await imagem.CopyToAsync(stream);
            }

            return "/uploads/relatorios/" + nomeArquivo;
        }

        public async Task<IActionResult> ExportarPdf(int id)
{
    var relatorio = await _context.Relatorios
        .Include(r => r.Propriedade)
        .FirstOrDefaultAsync(r => r.Id == id);

    if (relatorio == null)
    {
        return NotFound();
    }

    QuestPDF.Settings.License = LicenseType.Community;

    var pdf = Document.Create(container =>
    {
        container.Page(page =>
        {
            page.Margin(40);
            page.Size(PageSizes.A4);

            page.Header()
                .Text("Relatório Técnico - AgroConecta")
                .FontSize(20)
                .Bold();

            page.Content().Column(col =>
            {
                col.Spacing(15);

                col.Item().Text($"Propriedade: {relatorio.Propriedade?.Nome}");
                col.Item().Text($"Técnico: {relatorio.TecnicoId}");
                col.Item().Text($"Data de cadastro: {relatorio.CriadoEm:dd/MM/yyyy}");

                col.Item().LineHorizontal(1);

                col.Item().Text("Conteúdo:")
                    .FontSize(14)
                    .Bold();

                col.Item().Text(relatorio.Conteudo ?? "");

                if (!string.IsNullOrEmpty(relatorio.ImagemPath))
                {
                    var caminhoImagem = Path.Combine(
                        _webHostEnvironment.WebRootPath,
                        relatorio.ImagemPath.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString())
                    );

                    if (System.IO.File.Exists(caminhoImagem))
                    {
                        col.Item().Image(caminhoImagem).FitWidth();
                    }
                }
            });

            page.Footer()
                .AlignCenter()
                .Text($"Gerado em {DateTime.Now:dd/MM/yyyy HH:mm}");
        });
    }).GeneratePdf();

    return File(pdf, "application/pdf", $"relatorio-{relatorio.Id}.pdf");
}
        public async Task<IActionResult> RemoverImagem(int id)
        {
            var relatorio = await _context.Relatorios.FindAsync(id);

            if (relatorio == null) return NotFound();

            if (!string.IsNullOrEmpty(relatorio.ImagemPath))
            {
                var caminhoFisico = Path.Combine(
                    _webHostEnvironment.WebRootPath,
                    relatorio.ImagemPath.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString())
                );

                if (System.IO.File.Exists(caminhoFisico))
                    System.IO.File.Delete(caminhoFisico);

                relatorio.ImagemPath = null;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Edit), new { id });
        }
        private bool RelatorioExists(int id)
        {
            return _context.Relatorios.Any(e => e.Id == id);
        }
    }
}

