namespace AgroConecta.Models
{
    public class ClimaViewModel
    {
        public string Cidade { get; set; } = "Localização atual";
        public double Temperatura { get; set; }
        public double Umidade { get; set; }
        public double Vento { get; set; }
        public string MensagemErro { get; set; } = "";
    }
}