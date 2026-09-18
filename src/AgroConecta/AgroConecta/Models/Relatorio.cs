namespace AgroConecta.Models
{
    public class Relatorio
    {
        public int Id { get; set; }

        public int PropriedadeId { get; set; }
        public Propriedade? Propriedade { get; set; }

        public int TecnicoId { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public string Conteudo { get; set; } = string.Empty;

        public string? ImagemPath { get; set; }
    }
}
