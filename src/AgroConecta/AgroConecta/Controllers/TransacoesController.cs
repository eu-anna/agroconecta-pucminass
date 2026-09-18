using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgroConecta.Models;
using MercadoPago.Client.Preference;
using MercadoPago.Resource.Preference;

namespace AgroConecta.Controllers
{
    public class TransacoesController : BaseController
    {
        private readonly AppDbContext _context;

        public TransacoesController(AppDbContext context)
        {
            _context = context;
        }

        private int? GetLoggedInUserId()
        {
            var userIdStr = HttpContext.Session.GetString("UsuarioId");
            return int.TryParse(userIdStr, out int id) ? id : (int?)null;
        }

        public async Task<IActionResult> Create(int? PedidoId)
        {
            if (PedidoId == null)
            {
                return NotFound();
            }

            int? loggedInUser = GetLoggedInUserId();
            if (loggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var order = await _context.Pedidos
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefaultAsync(p => p.Id == PedidoId && p.UsuarioId == loggedInUser);

            if (order == null)
            {
                return NotFound();
            }

            var transaction = new Transacao
            {
                PedidoId = order.Id,
                Pedido = order,
                TipoPagamento = "MercadoPago"
            };

            return View(transaction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transacao transaction)
        {
            int? loggedInUser = GetLoggedInUserId();
            if (loggedInUser == null) return RedirectToAction("Login", "Account");

            var dbOrder = await _context.Pedidos
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefaultAsync(p => p.Id == transaction.PedidoId && p.UsuarioId == loggedInUser);

            if (dbOrder == null || transaction.Pedido == null) return NotFound();

            var user = await _context.Usuarios.FindAsync(dbOrder.UsuarioId);
            if (user == null) return NotFound();

            string fullAddress = $"{transaction.Pedido.Logradouro}, Nº {transaction.Pedido.Numero}, Bairro: {transaction.Pedido.Bairro} - {transaction.Pedido.Cidade}/{transaction.Pedido.Estado}, CEP: {transaction.Pedido.Cep}";
            string cleanCep = transaction.Pedido.Cep.Replace("-", "").Trim();
            string streetName = transaction.Pedido.Logradouro;
            string streetNumber = transaction.Pedido.Numero;

            dbOrder.NomeCliente = transaction.Pedido.NomeCliente;
            dbOrder.EnderecoEntrega = fullAddress;
            _context.Update(dbOrder);

            transaction.CriadoEm = DateTime.Now;
            transaction.AlteradoEm = DateTime.Now;

            transaction.Pedido = null;

            _context.Add(transaction);
            await _context.SaveChangesAsync();

            try
            {
                var client = new PreferenceClient();

                var preferenceItems = dbOrder.Itens.Select(item => new PreferenceItemRequest
                {
                    Id = item.Produto_id.ToString(),
                    Title = item.Produto?.Nome ?? "Produto AgroConecta",
                    Description = item.Produto?.Descricao ?? "Produto Agrícola",
                    Quantity = item.Quantidade,
                    CurrencyId = "BRL",
                    UnitPrice = (decimal)(item?.Produto?.Preco ?? 0)
                }).ToList();

                var nameParts = dbOrder.NomeCliente.Trim().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
                var firstName = nameParts.Length > 0 ? nameParts[0] : "Cliente";
                var lastName = nameParts.Length > 1 ? nameParts[1] : "Silva";

                string cleanNumberStr = System.Text.RegularExpressions.Regex.Replace(streetNumber ?? "", @"[^\d]", "");
                int finalStreetNumber = int.TryParse(cleanNumberStr, out int num) ? num : 0;

                string sandboxBuyerEmail = "test_user_163219306524914058@testuser.com"; // This email here is one of the test consumers we have registered in our mercado pago app. Cannot be changed.

                var request = new PreferenceRequest
                {
                    Items = preferenceItems,
                    Payer = new PreferencePayerRequest
                    {
                        Name = firstName,
                        Surname = lastName,
                        Email = sandboxBuyerEmail,
                        Address = new()
                        {
                            ZipCode = cleanCep,
                            StreetName = streetName,
                            StreetNumber = finalStreetNumber
                        }
                    },
                    BackUrls = new PreferenceBackUrlsRequest
                    {
                        Success = Url.Action("ProccessPaymentApiReturn", "Transacoes", null, Request.Scheme),
                        Pending = Url.Action("ProccessPaymentApiReturn", "Transacoes", null, Request.Scheme),
                        Failure = Url.Action("ProccessPaymentApiReturn", "Transacoes", null, Request.Scheme)
                    },
                    AutoReturn = "approved",
                    ExternalReference = dbOrder.Id.ToString()
                };

                Preference preference = await client.CreateAsync(request);

                return Redirect(preference.InitPoint);
            }
            catch (Exception)
            {
                TempData["ErroPagamento"] = "Não foi possível iniciar o fluxo de pagamento.";
                return RedirectToAction("Details", "Pedidos", new { id = dbOrder.Id });
            }
        }

        [HttpGet]
        public async Task<IActionResult> ProccessPaymentApiReturn(string status, string external_reference)
        {
            if (string.IsNullOrEmpty(external_reference) || !int.TryParse(external_reference, out int pedidoId))
            {
                return BadRequest("Dados de referência inválidos.");
            }

            var dbOrder = await _context.Pedidos.FindAsync(pedidoId);
            if (dbOrder == null) return NotFound();

            switch (status?.ToLower())
            {
                case "approved":
                    dbOrder.Status = StatusPedido.Em_processamento;
                    break;

                case "pending":
                case "in_process":
                    dbOrder.Status = StatusPedido.Aguardando_pagamento;
                    break;

                case "rejected":
                case "cancelled":
                    dbOrder.Status = StatusPedido.Cancelado;
                    break;

                default:
                    dbOrder.Status = StatusPedido.Aguardando_pagamento;
                    break;
            }

            _context.Update(dbOrder);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Pedidos", new { id = pedidoId });
        }
    }
}