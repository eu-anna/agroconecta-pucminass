using AgroConecta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AgroConecta.Controllers
{
    public class ProdutosController : BaseController
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        private void CriarCategoriasTemporarias()
        {
            if (!_context.CategoriasProduto.Any())
            {
                _context.CategoriasProduto.AddRange(
                    new CategoriaProduto { Nome = "Frutas", Desc = "Frutas frescas", Ativo = true },
                    new CategoriaProduto { Nome = "Verduras", Desc = "Verduras e hortaliças", Ativo = true },
                    new CategoriaProduto { Nome = "Grãos", Desc = "Grãos e cereais", Ativo = true },
                    new CategoriaProduto { Nome = "Laticínios", Desc = "Leite e derivados", Ativo = true },
                    new CategoriaProduto { Nome = "Outros", Desc = "Outros produtos", Ativo = true }
                );

                _context.SaveChanges();
            }
        }

        private void CarregarCategorias(int? categoriaId = null)
        {
            CriarCategoriasTemporarias();

            ViewBag.Categoria_id = new SelectList(
                _context.CategoriasProduto.ToList(),
                "Id",
                "Nome",
                categoriaId
            );
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.Ativo == 1)
                .ToListAsync();

            return View(products);
        }

        public IActionResult Create()
        {
            CarregarCategorias();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto product, IFormFile? productImage)
        {
            var producerIdStr = HttpContext.Session.GetString("UsuarioId");

            if (string.IsNullOrEmpty(producerIdStr))
            {
                return RedirectToAction("Login", "Account");
            }

            product.Produtor_id = int.Parse(producerIdStr);
            product.Ativo = 1; 

            ModelState.Remove("Categoria");
            ModelState.Remove("Produtor");
            ModelState.Remove("productImage");

            if (!ModelState.IsValid)
            {
                CarregarCategorias(product.Categoria_id);
                return View(product);
            }

            if (productImage != null && productImage.Length > 0)
            {
                using var memoryStream = new MemoryStream();
                await productImage.CopyToAsync(memoryStream);
                product.Imagem = memoryStream.ToArray();
            }

            _context.Produtos.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ManageProducerProducts));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var productData = await _context.Produtos.FindAsync(id);

            if (productData == null)
                return NotFound();

            CarregarCategorias(productData.Categoria_id);
            return View(productData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Produto product, IFormFile? productImage)
        {
            if (id != product.Id)
                return NotFound();

            ModelState.Remove("Categoria");
            ModelState.Remove("productImage");
            ModelState.Remove("Imagem");

            if (!ModelState.IsValid)
            {
                CarregarCategorias(product.Categoria_id);
                return View(product);
            }

            if (product.Estoque == 0)
                product.Ativo = 0;
            else
                product.Ativo = 1;

            if (productImage != null && productImage.Length > 0)
            {
                using var memoryStream = new MemoryStream();
                await productImage.CopyToAsync(memoryStream);
                product.Imagem = memoryStream.ToArray();
            }
            else
            {
                var original = await _context.Produtos
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id == id);
                product.Imagem = original?.Imagem;
            }

            _context.Produtos.Update(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var productData = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (productData == null)
                return NotFound();

            return View(productData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var productData = await _context.Produtos.FindAsync(id);

            if (productData == null)
                return NotFound();

            _context.Produtos.Remove(productData);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var productData = await _context.Produtos.FindAsync(id);

            if (productData == null)
                return NotFound();

            productData.Ativo = productData.Ativo == 1 ? 0 : 1;

            _context.Produtos.Update(productData);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ManageProducerProducts));
        }

        public async Task<IActionResult> ManageProducerProducts()
        {
            var producerIdStr = HttpContext.Session.GetString("UsuarioId");

            if (string.IsNullOrEmpty(producerIdStr))
            {
                return RedirectToAction("Login", "Account");
            }

            int producerId = int.Parse(producerIdStr);

            var producerProducts = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.Produtor_id == producerId)
                .ToListAsync();

            return View(producerProducts);
        }
    }
}
