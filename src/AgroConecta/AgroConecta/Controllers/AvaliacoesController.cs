using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgroConecta.Models;


namespace AgroConecta.Controllers
{
    public class AvaliacoesController : Controller
    {
        private readonly AppDbContext _context;

        public AvaliacoesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Avaliacao model)
        {
            var jaExiste = await _context.Avaliacoes.AnyAsync(a => a.PedidoId == model.PedidoId);

            if (jaExiste)
            {
                TempData["Erro"] = "Este pedido já foi avaliado.";
                return RedirectToAction("Details", "Pedidos", new { id = model.PedidoId });
            }

            if (!ModelState.IsValid)
                return RedirectToAction("Details", "Pedidos", new { id = model.PedidoId });

            model.CriadoEm = DateTime.Now;

            _context.Avaliacoes.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Pedidos", new { id = model.PedidoId });
        }
    }
}