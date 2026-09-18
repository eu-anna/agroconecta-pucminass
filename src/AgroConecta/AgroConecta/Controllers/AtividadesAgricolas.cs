using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AgroConecta.Controllers
{
    public class AtividadesAgricolasController : BaseController
    {
        private readonly AppDbContext _context;

        public AtividadesAgricolasController(AppDbContext context)
        {
            _context = context;
        }

        private void CarregarSelectLists(AtividadeAgricola? atividade = null)
        {
            ViewBag.Propriedades = new SelectList(
                _context.Propriedades.ToList(),
                "Id",
                "Nome",
                atividade?.PropriedadeId
            );

            ViewBag.Culturas = new SelectList(
                _context.Culturas.ToList(),
                "Id",
                "NomeCultura",
                atividade?.CulturaId
            );
        }

        public async Task<IActionResult> Index()
        {
            var atividades = _context.AtividadesAgricolas
                .Include(a => a.Propriedade)
                .Include(a => a.Cultura);

            return View(await atividades.ToListAsync());
        }

        public IActionResult Create()
        {
            CarregarSelectLists();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AtividadeAgricola atividade)
        {
            if (ModelState.IsValid)
            {
                _context.AtividadesAgricolas.Add(atividade);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            CarregarSelectLists(atividade);
            return View(atividade);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var atividade = await _context.AtividadesAgricolas.FindAsync(id);

            if (atividade == null)
                return NotFound();

            CarregarSelectLists(atividade);
            return View(atividade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AtividadeAgricola atividade)
        {
            if (id != atividade.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(atividade);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            CarregarSelectLists(atividade);
            return View(atividade);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var atividade = await _context.AtividadesAgricolas.FindAsync(id);

            if (atividade != null)
            {
                _context.AtividadesAgricolas.Remove(atividade);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
