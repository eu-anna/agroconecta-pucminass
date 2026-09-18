using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgroConecta.Models;

namespace AgroConecta.Controllers
{
    public class PropriedadesController : BaseController
    {
        private readonly AppDbContext _context;

        public PropriedadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Propriedades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Propriedades.ToListAsync());
        }

        // GET: Propriedades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propriedade = await _context.Propriedades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propriedade == null)
            {
                return NotFound();
            }

            return View(propriedade);
        }

        // GET: Propriedades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propriedades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create([Bind("Id,Nome,Area,LocalizacaoGeo,CriadoPor,Cib")] Propriedade propriedade)
{
    Console.WriteLine("ENTROU NO POST CREATE");
    Console.WriteLine($"Nome: {propriedade.Nome}");
    Console.WriteLine($"Area: {propriedade.Area}");
    Console.WriteLine($"Localizacao: {propriedade.LocalizacaoGeo}");
    Console.WriteLine($"CIB: {propriedade.Cib}");
    Console.WriteLine($"CriadoPor: {propriedade.CriadoPor}");

    if (ModelState.IsValid)
    {
        _context.Add(propriedade);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    foreach (var erro in ModelState.Values.SelectMany(v => v.Errors))
    {
        Console.WriteLine("ERRO MODELSTATE: " + erro.ErrorMessage);
    }

    return View(propriedade);
}

        // GET: Propriedades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propriedade = await _context.Propriedades.FindAsync(id);
            if (propriedade == null)
            {
                return NotFound();
            }
            return View(propriedade);
        }

        // POST: Propriedades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Area,LocalizacaoGeo,CriadoPor,Cib")] Propriedade propriedade)
        {
            if (id != propriedade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propriedade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropriedadeExists(propriedade.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(propriedade);
        }

        // GET: Propriedades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propriedade = await _context.Propriedades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propriedade == null)
            {
                return NotFound();
            }

            return View(propriedade);
        }

        // POST: Propriedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propriedade = await _context.Propriedades.FindAsync(id);
            if (propriedade != null)
            {
                _context.Propriedades.Remove(propriedade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropriedadeExists(int id)
        {
            return _context.Propriedades.Any(e => e.Id == id);
        }
    }
}
