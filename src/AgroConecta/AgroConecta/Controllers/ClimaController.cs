using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AgroConecta.Controllers
{
    public class ClimaController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObterClima(double latitude, double longitude)
        {
            try
            {
                string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,relative_humidity_2m,wind_speed_10m&timezone=auto";

                using HttpClient client = new HttpClient();
                string resposta = await client.GetStringAsync(url);

                using JsonDocument json = JsonDocument.Parse(resposta);
                var atual = json.RootElement.GetProperty("current");

                return Json(new
                {
                    temperatura = atual.GetProperty("temperature_2m").GetDouble(),
                    umidade = atual.GetProperty("relative_humidity_2m").GetDouble(),
                    vento = atual.GetProperty("wind_speed_10m").GetDouble()
                });
            }
            catch
            {
                return BadRequest(new
                {
                    erro = "Não foi possível carregar os dados climáticos."
                });
            }
        }
    }
}
