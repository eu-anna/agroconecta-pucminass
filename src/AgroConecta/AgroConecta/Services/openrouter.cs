using Microsoft.Extensions.Configuration; // Adicione este using
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace AgroConecta.Services
{
    public class Openrouter
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration; // Variável para ler o JSON

        // Modificamos o construtor para receber a configuração por Injeção de Dependência
        public Openrouter(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
        }

        public async Task<string> AnalisarImagem(string caminhoImagem)
        {
            // O .NET procura primeiro nas Variáveis de Ambiente (Render). 
            // Se não achar, ele busca no appsettings.Development.json automaticamente!
            string? apiKey = _configuration["OpenAI:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                return "Erro: API KEY da OpenAI não encontrada no appsettings ou no ambiente.";
            }

            try
            {
                byte[] imagemBytes = await File.ReadAllBytesAsync(caminhoImagem);
                string base64Imagem = Convert.ToBase64String(imagemBytes);

                var requestBody = new
                {
                    model = "gpt-4o-mini",
                    messages = new object[]
                    {
                        new
                        {
                            role = "user",
                            content = new object[]
                            {
                                new
                                {
                                    type = "text",
                                    text = @"Analise a imagem agrícola enviada.
                                            Responda somente em português do Brasil.
                                            Use linguagem simples, como se estivesse explicando para um agricultor.
                                            Não use markdown.
                                            Não use asteriscos.
                                            Não escreva textos muito longos.

                                            Responda exatamente neste formato (incluindo os rótulos):

                                            Cultura:
                                            Escreva apenas o nome simples da cultura identificada (exemplo: Milho, Soja, Café, Tomate). Apenas uma palavra ou nome composto simples.

                                            Diagnóstico:
                                            Escreva uma breve descrição dizendo o que aparece na imagem e o estado da cultura.

                                            Recomendações:
                                            Escreva uma breve descrição do que o agricultor pode fazer.

                                            Não pare a resposta no meio."
                                },
                                new
                                {
                                    type = "image_url",
                                    image_url = new
                                    {
                                        url = $"data:image/jpeg;base64,{base64Imagem}"
                                    }
                                }
                            }
                        }
                    },
                    max_tokens = 900
                };

                string json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var response = await _httpClient.PostAsync(
                    "https://api.openai.com/v1/chat/completions",
                    content
                );

                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return "Erro da API OpenAI: " + responseString;
                }

                var obj = JObject.Parse(responseString);
                var texto = obj["choices"]?[0]?["message"]?["content"]?.ToString();

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    return texto;
                }

                return "Erro: A OpenAI respondeu, mas não retornou texto.";
            }
            catch (Exception ex)
            {
                return "Erro ao analisar imagem na OpenAI: " + ex.Message;
            }
        }
    }
}