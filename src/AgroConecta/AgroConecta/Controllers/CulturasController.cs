using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AgroConecta.Controllers
{
    public class CulturasController : BaseController
    {
        private readonly AppDbContext _context;

        public CulturasController(AppDbContext context)
        {
            _context = context;
        }

        private void CriarPropriedadesTemporarias()
        {
            if (!_context.Propriedades.Any())
            {
                _context.Propriedades.Add(new Propriedade { Nome = "Fazenda Palmeiras" });
                _context.Propriedades.Add(new Propriedade { Nome = "Fazenda Bela Vista" });
                _context.SaveChanges();
            }
        }

        public async Task<IActionResult> Index()
        {
            CriarPropriedadesTemporarias();

            var culturas = _context.Culturas.Include(c => c.Propriedade);
            return View(await culturas.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var cultura = await _context.Culturas
                .Include(c => c.Propriedade)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cultura == null)
            {
                return NotFound();
            }

            return View(cultura);
        }

        public IActionResult Create()
        {
            CriarPropriedadesTemporarias();
            ViewBag.PropriedadeId = new SelectList(_context.Propriedades, "Id", "Nome");
            return View();
        }

    [HttpPost]
public async Task<IActionResult> Create(Cultura cultura)
{
    if (ModelState.IsValid)
    {
        _context.Culturas.Add(cultura);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    CriarPropriedadesTemporarias();
    ViewBag.PropriedadeId = new SelectList(_context.Propriedades, "Id", "Nome", cultura.PropriedadeId);
    return View(cultura);
}

        public async Task<IActionResult> Edit(int id)
        {
            var cultura = await _context.Culturas.FindAsync(id);

            if (cultura == null)
            {
                return NotFound();
            }

            CriarPropriedadesTemporarias();
            ViewBag.PropriedadeId = new SelectList(_context.Propriedades, "Id", "Nome", cultura.PropriedadeId);

            return View(cultura);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cultura cultura)
        {
            if (id != cultura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Culturas.Update(cultura);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            CriarPropriedadesTemporarias();
            ViewBag.PropriedadeId = new SelectList(_context.Propriedades, "Id", "Nome", cultura.PropriedadeId);

            return View(cultura);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cultura = await _context.Culturas
                .Include(c => c.Propriedade)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cultura == null)
            {
                return NotFound();
            }

            return View(cultura);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cultura = await _context.Culturas.FindAsync(id);

            if (cultura == null)
            {
                return NotFound();
            }

            var analises = _context.AnalisesCulturas
                .Where(a => a.CulturaId == id);

            _context.AnalisesCulturas.RemoveRange(analises);

            var atividades = _context.AtividadesAgricolas
                .Where(a => a.CulturaId == id);

            _context.AtividadesAgricolas.RemoveRange(atividades);

            _context.Culturas.Remove(cultura);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
