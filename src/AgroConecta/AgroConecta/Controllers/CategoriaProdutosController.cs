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
    public class CategoriaProdutosController : BaseController
    {
        private readonly AppDbContext _context;

        public CategoriaProdutosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CategoriaProdutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriasProduto.ToListAsync());
        }


        // GET: CategoriaProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaProdutos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] CategoriaProduto categoriaProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaProduto);
        }

        // GET: CategoriaProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaProduto = await _context.CategoriasProduto.FindAsync(id);
            if (categoriaProduto == null)
            {
                return NotFound();
            }
            return View(categoriaProduto);
        }

        // POST: CategoriaProdutos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] CategoriaProduto categoriaProduto)
        {
            if (id != categoriaProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaProdutoExists(categoriaProduto.Id))
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
            return View(categoriaProduto);
        }

        // POST: CategoriaProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaProduto = await _context.CategoriasProduto.FindAsync(id);
            if (categoriaProduto != null)
            {
                _context.CategoriasProduto.Remove(categoriaProduto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaProdutoExists(int id)
        {
            return _context.CategoriasProduto.Any(e => e.Id == id);
        }
    }
}
