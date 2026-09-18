using AgroConecta.Models;
using AgroConecta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AgroConecta.Controllers
{
    public class AnalisesCulturasController : BaseController
    {
        private readonly AppDbContext _context;
        private readonly Openrouter _geminiService; // Instância do serviço convertido para OpenAI

        // O ASP.NET injeta o IConfiguration no Controller de forma automática
        public AnalisesCulturasController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _geminiService = new Openrouter(configuration); // Passando a config para o serviço
        }

        public async Task<IActionResult> Index()
        {
            var analises = await _context.AnalisesCulturas
                .Include(a => a.Cultura)
                .OrderByDescending(a => a.CriadoEm)
                .ToListAsync();

            return View(analises);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AnaliseCultura analise, IFormFile ArquivoImagem)
        {
            // 1. Remove validações automáticas de propriedades geradas dinamicamente
            ModelState.Remove("Imagem");
            ModelState.Remove("Diagnostico");
            ModelState.Remove("Recomendacoes");
            ModelState.Remove("CulturaId");
            ModelState.Remove("Cultura");

            // 2. Validação básica do arquivo de imagem
            if (ArquivoImagem == null || ArquivoImagem.Length == 0)
            {
                ModelState.AddModelError("", "Selecione uma imagem válida.");
                return View(analise);
            }

            // 3. Salvamento do arquivo físico no servidor local (/wwwroot/uploads)
            var pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            var nomeArquivo = Guid.NewGuid() + Path.GetExtension(ArquivoImagem.FileName);
            var caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using (var stream = new FileStream(caminhoCompleto, FileMode.Create))
            {
                await ArquivoImagem.CopyToAsync(stream);
            }

            analise.Imagem = "/uploads/" + nomeArquivo;

            // 4. Dispara a chamada direto para a API da OpenAI
            // 4. Dispara a chamada direto para a API da OpenAI
            var respuestaIA = await _geminiService.AnalisarImagem(caminhoCompleto);

            if (respuestaIA.StartsWith("Erro"))
            {
                ModelState.AddModelError("", respuestaIA);
                return View(analise);
            }

            // 5. Nova quebra de String em 3 partes (Cultura, Diagnóstico e Recomendações)
            string nomeCulturaIdentificada = "Não Identificada";
            string diagnostico = respuestaIA;
            string recomendacoes = "Não foi possível gerar recomendações específicas para esta imagem.";

            try
            {
                // Isola a Cultura tirando o texto até "Diagnóstico:"
                if (respuestaIA.Contains("Cultura:") && respuestaIA.Contains("Diagnóstico:"))
                {
                    int inicioCultura = respuestaIA.IndexOf("Cultura:") + "Cultura:".Length;
                    int fimCultura = respuestaIA.IndexOf("Diagnóstico:");
                    nomeCulturaIdentificada = respuestaIA.Substring(inicioCultura, fimCultura - inicioCultura).Trim();
                }

                // Isola o Diagnóstico e as Recomendações baseado no split antigo
                if (respuestaIA.Contains("Recomendações:"))
                {
                    var partesRestantes = respuestaIA.Split("Recomendações:");

                    // Remove o rótulo "Diagnóstico:" que sobrou do texto inicial
                    diagnostico = partesRestantes[0].Replace("Cultura:", "")
                                                    .Replace(nomeCulturaIdentificada, "")
                                                    .Replace("Diagnóstico:", "")
                                                    .Trim();

                    recomendacoes = partesRestantes[1].Trim();
                }
            }
            catch
            {
                // Caso a IA desconfigure o formato por algum motivo, garante valores padrão
                diagnostico = respuestaIA;
            }

            // 6. Instancia a Nova Cultura com o nome real retornado pela IA!
            var primeiraPropriedade = await _context.Propriedades.FirstOrDefaultAsync();

            if (primeiraPropriedade == null)
            {
                ModelState.AddModelError("", "Erro: Você precisa cadastrar pelo menos uma Propriedade no sistema antes de fazer análises.");
                return View(analise);
            }

            var novaCultura = new Cultura
            {
                NomeCultura = nomeCulturaIdentificada,
                DataPlantio = DateTime.Now,
                Status = "Analisada",
                DataIrrigacao = DateTime.Now,
                DataPrevistaColheita = DateTime.Now.AddMonths(4),
                AreaPlantio = 1.0,
                PropriedadeId = primeiraPropriedade.Id // <--- Usa o ID dinâmico e correto do seu banco!
            };

            _context.Culturas.Add(novaCultura);
            await _context.SaveChangesAsync();

            // 7. Amarra a análise à Cultura recém-criada e finaliza
            analise.CulturaId = novaCultura.Id;
            analise.Diagnostico = diagnostico;
            analise.Recomendacoes = recomendacoes;
            analise.CriadoEm = DateTime.Now;

            _context.AnalisesCulturas.Add(analise);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Resultado), new { id = analise.Id });
        }

        public async Task<IActionResult> Resultado(int id)
        {
            var analise = await _context.AnalisesCulturas
                .Include(a => a.Cultura)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (analise == null)
            {
                return NotFound();
            }

            return View(analise);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var analise = await _context.AnalisesCulturas.FindAsync(id);

            if (analise != null)
            {
                _context.AnalisesCulturas.Remove(analise);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetDashboardData()
        {
            try
            {
                // 1. DADOS PARA OS CARDS (KPIs)
                // Conta apenas culturas que realmente aparecem em alguma análise
                var totalCulturas = await _context.AnalisesCulturas
                    .Select(a => a.CulturaId)
                    .Distinct()
                    .CountAsync();
                var totalAtividades = await _context.AtividadesAgricolas.CountAsync();

                var ultimoDiagnostico = await _context.AnalisesCulturas
                    .Include(a => a.Cultura)
                    .OrderByDescending(a => a.CriadoEm)
                    .Select(a => a.Cultura.NomeCultura)
                    .FirstOrDefaultAsync() ?? "Nenhum";

                // 2. GRÁFICO DE PIZZA 1: TIPOS DE CULTURA (Verifica se há dados para não dar erro)
                var dadosCulturas = await _context.AnalisesCulturas
                    .Include(a => a.Cultura)
                    .GroupBy(a => a.Cultura.NomeCultura)
                    .Select(g => new {
                        Item = string.IsNullOrEmpty(g.Key) ? "Não Informado" : g.Key,
                        Quantidade = g.Count()
                    })
                    .ToListAsync();

                // 3. GRÁFICO DE PIZZA 2: STATUS DAS ATIVIDADES
                var dadosAtividades = await _context.AtividadesAgricolas
                    .GroupBy(a => a.Status)
                    .Select(g => new {
                        Item = string.IsNullOrEmpty(g.Key) ? "Sem Status" : g.Key,
                        Quantidade = g.Count()
                    })
                    .ToListAsync();

                return Json(new
                {
                    cards = new
                    {
                        totalCulturas,
                        ultimoDiagnostico,
                        totalAtividades
                    },
                    graficoCulturas = dadosCulturas,
                    graficoAtividades = dadosAtividades
                });
            }
            catch (Exception ex)
            {
                // Em vez de estourar um erro vazio na tela, devolvemos o texto do erro real como JSON
                return Json(new { erro = true, mensagem = ex.Message, detalhe = ex.InnerException?.Message });
            }
        }
    }
}