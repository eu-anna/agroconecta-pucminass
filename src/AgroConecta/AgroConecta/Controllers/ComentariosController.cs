using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AgroConecta.Controllers
{
    public class ComentariosController : BaseController
    {
        private readonly AppDbContext _context;

        public ComentariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ComentarioModel comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.CriadoEm = DateTime.Now;
                _context.Comentarios.Add(comentario);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Details", "Topicos", new { id = comentario.TopicoId });
        }

        [HttpPost]
        public async Task<IActionResult> Curtir(int id, int topicoId)
        {
            await _context.Comentarios
                .Where(c => c.Id == id)
                .ExecuteUpdateAsync(setters => setters.SetProperty(c => c.Curtidas, c => c.Curtidas + 1));

            return RedirectToAction("Details", "Topicos", new { id = topicoId });
        }
    }
}
