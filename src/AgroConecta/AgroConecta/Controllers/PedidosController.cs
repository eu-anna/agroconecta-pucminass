using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgroConecta.Models;


namespace AgroConecta.Controllers
{
    public class PedidosController : BaseController
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userIdStr = HttpContext.Session.GetString("UsuarioId");

            if (!int.TryParse(userIdStr, out int loggedClient))
            {
                return RedirectToAction("Login", "Account");
            }

            var shoppingCart = await _context.Pedidos
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefaultAsync(p => p.UsuarioId == loggedClient && p.Status == StatusPedido.Em_aberto);

            if (shoppingCart == null)
            {
                return View(new Pedido { Itens = new List<ItemPedido>() });
            }

            return View(shoppingCart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST: Pedidos/AddToCart
        public async Task<IActionResult> AddToCart(int Produto_id, int quantity = 1)
        {
            var userIdStr = HttpContext.Session.GetString("UsuarioId");

            if (!int.TryParse(userIdStr, out int loggedClient))
            {
                return RedirectToAction("Login", "Account");
            }

            var product = await _context.Produtos.FindAsync(Produto_id);

            if (product == null)
            {
                return NotFound();
            }

            var order = await _context.Pedidos.Include(p => p.Itens).FirstOrDefaultAsync(p => p.UsuarioId == loggedClient && p.Status == StatusPedido.Em_aberto);

            if (order == null)
            {
                order = new Pedido
                {
                    UsuarioId = loggedClient,
                    Status = StatusPedido.Em_aberto,
                    CriadoEm = DateTime.Now,
                    AlteradoEm = DateTime.Now,
                    SubTotal = 0,
                    Total = 0
                };
                _context.Pedidos.Add(order);
                await _context.SaveChangesAsync();
            }

            var itemExistente = order.Itens.FirstOrDefault(i => i.Produto_id == Produto_id);
            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantity;
            }
            else
            {
                var novoItem = new ItemPedido
                {
                    Pedido_id = order.Id,
                    Produto_id = Produto_id,
                    Quantidade = quantity
                };
                _context.ItensPedido.Add(novoItem);
            }

            await UpdateTotals(order.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateQuantity(int itemId, int quantity)
        {
            var item = await _context.ItensPedido.FindAsync(itemId);
            if (item != null && quantity > 0)
            {
                item.Quantidade = quantity;
                await _context.SaveChangesAsync();
                await UpdateTotals(item.Pedido_id);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> RemoveItem(int id)
        {
            var item = await _context.ItensPedido.FindAsync(id);
            if (item != null)
            {
                int Pedido_id = item.Pedido_id;
                _context.ItensPedido.Remove(item);
                await _context.SaveChangesAsync();
                await UpdateTotals(Pedido_id);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> EmptyCart(int id)
        {
            var itens = _context.ItensPedido.Where(i => i.Pedido_id == id);
            _context.ItensPedido.RemoveRange(itens);
            await _context.SaveChangesAsync();
            await UpdateTotals(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task UpdateTotals(int? id)
        {
            var order = await _context.Pedidos.Include(p => p.Itens)
              .ThenInclude(i => i.Produto)
              .FirstOrDefaultAsync(p => p.Id == id);

            if (order != null && order.Itens.Any())
            {
                order.SubTotal = (decimal)order.Itens.Sum(i => i.Quantidade * (double)i.Produto.Preco);
                order.Total = order.SubTotal;
                order.AlteradoEm = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IActionResult> ListarPedidos()
        {
            var userIdStr = HttpContext.Session.GetString("UsuarioId");

            if (!int.TryParse(userIdStr, out int loggedClient))
            {
                return RedirectToAction("Login", "Account");
            }

            return RedirectToAction("Vendas");
        }

        [HttpPost]
        public IActionResult AlterarStatus(int pedidoId, StatusPedido novoStatus)
        {
            if (TipoUsuario != "Produtor")
                return RedirectToAction("Index", "Home");

            var pedido = _context.Pedidos.FirstOrDefault(p => p.Id == pedidoId);

            if (pedido == null)
                return NotFound();

            if (pedido.Status == StatusPedido.Entregue || pedido.Status == StatusPedido.Cancelado)
                return RedirectToAction("Vendas");

            pedido.Status = novoStatus;

            _context.SaveChanges();

            return RedirectToAction("Vendas");
        }

        public async Task<IActionResult> Vendas()
        {
            if (TipoUsuario != "Produtor")
            {
                return RedirectToAction("Index", "Home");
            }

            var pedidos = await _context.Pedidos
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .ToListAsync();

            return View(pedidos);
        }

        public IActionResult VendasMock()
        {
            var pedido = new Pedido
            {
                Id = 999,
                UsuarioId = 1,
                Status = StatusPedido.Enviado,
                CriadoEm = DateTime.Now,
                AlteradoEm = DateTime.Now,
                SubTotal = 150,
                Total = 150,
                Itens = new List<ItemPedido>
            {
            new ItemPedido
            {
                Id = 1,
                Quantidade = 2,
                Produto = new Produto
                {
                    Id = 1,
                    Nome = "Tomate Orgânico",
                    Preco = 10,
                    Descricao = "TESTE TOMATE"
                }
            },
            new ItemPedido
            {
                Id = 2,
                Quantidade = 5,
                Produto = new Produto
                {
                    Id = 2,
                    Nome = "Alface Hidropônica",
                    Preco = 5,
                    Descricao = "TESTE ALFACE"
                }
            }
        }
            };

            var pedidos = new List<Pedido> { pedido };

            return View("Vendas", pedidos);
        }

        public async Task<IActionResult> ManageUserPurchases()
        {
            var userIdStr = HttpContext.Session.GetString("UsuarioId");

            if (!int.TryParse(userIdStr, out int loggedClient))
            {
                return RedirectToAction("Login", "Account");
            }

            var orders = await _context.Pedidos
                .Where(p => p.UsuarioId == loggedClient && p.Status != StatusPedido.Em_aberto)
                .OrderByDescending(p => p.CriadoEm)
                .ToListAsync();

            return View(orders);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var userIdStr = HttpContext.Session.GetString("UsuarioId");

            if (!int.TryParse(userIdStr, out int loggedClient))
            {
                return RedirectToAction("Login", "Account");
            }

            var order = await _context.Pedidos
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefaultAsync(p => p.Id == id &&
                                          p.UsuarioId == loggedClient);

            if (order == null)
                return NotFound();

            var avaliacao = await _context.Avaliacoes
                .FirstOrDefaultAsync(a => a.PedidoId == id);

            ViewBag.Avaliacao = avaliacao;

            return View(order);
        }
    }
}
