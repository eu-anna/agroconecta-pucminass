using AgroConecta.Data;
using AgroConecta.Models;
// using AgroConecta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgroConecta.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        // private readonly IEmailService _emailService;

        // public AccountController(AppDbContext context, IEmailService emailService)
        // {
        //     _context = context;
        //      _emailService = emailService;
        // }

        public AccountController(AppDbContext context)
{
    _context = context;
}

        // LOGIN
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email && u.Senha == senha && u.Ativo);

            if (usuario == null)
            {
                ViewBag.Erro = "Email ou senha inválidos";
                return View();
            }

            HttpContext.Session.SetString("UsuarioLogado", usuario.Email);
            HttpContext.Session.SetString("NomeUsuario", usuario.Nome);
            HttpContext.Session.SetString("TipoUsuario", usuario.TipoUsuario);
            HttpContext.Session.SetString("UsuarioId", usuario.Id.ToString());

            return RedirectToAction("Index", "Home");
        }

        // CADASTRO
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            // // AQUI ESTA O ENVIO DO EMAIL
            // await _emailService.EnviarEmailAsync(
            //     usuario.Email,
            //     "Bem-vindo ao AgroConecta",
            //     $@"
            //     <h2>Olá, {usuario.Nome}!</h2>
            //     <p>Seja bem-vindo ao AgroConecta.</p>
            //     <p>Sua conta foi criada com sucesso.</p>
            //     <p>Agora você já pode acessar a plataforma.</p>
            //     "
            // );

            return RedirectToAction("Login");
        }

        // EDITAR PERFIL
        public IActionResult Perfil()
        {
            var email = HttpContext.Session.GetString("UsuarioLogado");

            if (email == null)
            {
                return RedirectToAction("Login");
            }

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                return RedirectToAction("Login");
            }

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Perfil(Usuario usuarioAtualizado)
        {
            var email = HttpContext.Session.GetString("UsuarioLogado");

            if (email == null)
            {
                return RedirectToAction("Login");
            }

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                return RedirectToAction("Login");
            }

            usuario.Nome = usuarioAtualizado.Nome;
            usuario.Email = usuarioAtualizado.Email;
            usuario.TipoUsuario = usuarioAtualizado.TipoUsuario;

            _context.SaveChanges();

            HttpContext.Session.SetString("UsuarioLogado", usuario.Email);
            HttpContext.Session.SetString("NomeUsuario", usuario.Nome);
            HttpContext.Session.SetString("TipoUsuario", usuario.TipoUsuario);

            ViewBag.Sucesso = "Perfil atualizado com sucesso.";

            return View(usuario);
        }

        // DESATIVAR CONTA
        public IActionResult DesativarConta()
        {
            var email = HttpContext.Session.GetString("UsuarioLogado");

            if (email == null)
            {
                return RedirectToAction("Login");
            }

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                return RedirectToAction("Login");
            }

            usuario.Ativo = false;

            _context.SaveChanges();

            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }

        // ESQUECI SENHA
[HttpGet]
public IActionResult EsqueciSenha()
{
    return View();
}

[HttpPost]
public async Task<IActionResult> EsqueciSenha(string email)
{
    var usuario = await _context.Usuarios
        .FirstOrDefaultAsync(u => u.Email == email);

    if (usuario == null)
    {
        ViewBag.Mensagem = "Se o e-mail existir, um link será gerado.";
        return View();
    }

    usuario.ResetToken = Guid.NewGuid().ToString();
    usuario.ResetTokenExpiraEm = DateTime.Now.AddMinutes(30);

    await _context.SaveChangesAsync();

    var link = Url.Action(
        "RedefinirSenha",
        "Account",
        new { token = usuario.ResetToken },
        Request.Scheme);

    ViewBag.LinkTeste = link;
    ViewBag.Mensagem = "Link gerado com sucesso.";

    return View();
}

// REDEFINIR SENHA
[HttpGet]
public IActionResult RedefinirSenha(string token)
{
    var usuario = _context.Usuarios
        .FirstOrDefault(u =>
            u.ResetToken == token &&
            u.ResetTokenExpiraEm > DateTime.Now);

    if (usuario == null)
    {
        return Content("Token inválido ou expirado.");
    }

    ViewBag.Token = token;

    return View();
}

[HttpPost]
public async Task<IActionResult> RedefinirSenha(string token, string novaSenha)
{
    var usuario = await _context.Usuarios
        .FirstOrDefaultAsync(u =>
            u.ResetToken == token &&
            u.ResetTokenExpiraEm > DateTime.Now);

    if (usuario == null)
    {
        return Content("Token inválido ou expirado.");
    }

    usuario.Senha = novaSenha;

    usuario.ResetToken = null;
    usuario.ResetTokenExpiraEm = null;

    await _context.SaveChangesAsync();

    return RedirectToAction("Login");
}

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
