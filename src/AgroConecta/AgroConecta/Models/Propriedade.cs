namespace AgroConecta.Models
{
    public class Propriedade
    {
        public int Id { get; set; }

        public ICollection<Cultura> Culturas { get; set; } = new List<Cultura>();

        public string Nome { get; set; } = string.Empty;

        public double Area { get; set; }

        public string LocalizacaoGeo { get; set; } = string.Empty;

        public int CriadoPor { get; set; }

        public string Cib { get; set; } = string.Empty;

        public ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
    }
}
