using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace AgroConecta.Controllers
{
    public class TopicosController : BaseController
    {
        private readonly AppDbContext _context;

        public TopicosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? categoriaId)
        {
            ViewBag.CategoriaId = categoriaId;
            var query = _context.Topicos
                .Include(t => t.Categoria)
                .Include(t => t.Comentarios)
                .AsQueryable();

            if (categoriaId.HasValue)
            {
                query = query.Where(t => t.CategoriaId == categoriaId);
                var categoria = await _context.CategoriasForum.FindAsync(categoriaId);
                if (categoria != null)
                {
                    ViewBag.CategoriaNome = categoria.Nome;
                }
            }

            var dados = await query.ToListAsync();
            return View(dados);
        }
        public IActionResult Create(int? categoriaId)
        {
            if (categoriaId == null || categoriaId == 0)
            {
                return RedirectToAction("Index", "CategoriasForum");
            }

            var topico = new TopicoModel { CategoriaId = categoriaId.Value };

            return View(topico);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TopicoModel topico)
        {
            if (ModelState.IsValid)
            {
                topico.CriadoEm = DateTime.Now;
                _context.Topicos.Add(topico);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", new { categoriaId = topico.CategoriaId });
            }
            return View(topico);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var topico = await _context.Topicos.FindAsync(id);

            if (topico == null) return NotFound();

            return View(topico);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TopicoModel topico)
        {
            if (id != topico.Id) return NotFound();

            ModelState.Remove("Categoria");
            ModelState.Remove("Comentarios");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Topicos.Update(topico);
                    await _context.SaveChangesAsync();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
                {
                    if (!_context.Topicos.Any(e => e.Id == topico.Id))
                        return NotFound();
                    else
                        throw;
                }

                return RedirectToAction("Index", new { categoriaId = topico.CategoriaId });
            }

            return View(topico);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var topico = await _context.Topicos
                .Include(t => t.Categoria)
                .Include(t => t.Comentarios)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (topico == null) return NotFound();

            return View(topico);
        }

        [HttpPost]
        public async Task<IActionResult> Curtir(int id)
        {
            await _context.Topicos
                .Where(t => t.Id == id)
                .ExecuteUpdateAsync(setters => setters.SetProperty(t => t.Curtidas, t => t.Curtidas + 1));
            return RedirectToAction(nameof(Details), new { id = id });
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Topicos
                .Where(t => t.Id == id)
                .ExecuteDeleteAsync();

            return RedirectToAction("Index");
        }
    }
}
