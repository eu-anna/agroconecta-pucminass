using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace AgroConecta.Controllers
{
    public class CategoriasForumController : BaseController
    {
        private readonly AppDbContext _context;

        public CategoriasForumController(AppDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var dados = await _context.CategoriasForum.Include(c => c.Topicos).ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoriaForum categoria)
        {
            if (ModelState.IsValid)
            {
                _context.CategoriasForum.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.CategoriasForum.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CategoriaForum categoria)
        {
            if (id != categoria.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.CategoriasForum.Update(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.CategoriasForum
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            return RedirectToAction("Index");
        }

    }
}
