using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    public class AnaliseCultura
    {
        public int Id { get; set; }

        [Display(Name = "Cultura")]
        public int CulturaId { get; set; }

        public Cultura? Cultura { get; set; }

        public string Diagnostico { get; set; } = string.Empty;

        [Display(Name = "Recomendações")]
        public string Recomendacoes { get; set; } = string.Empty;

        public string? Imagem { get; set; }

        [Display(Name = "Criado em")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        [NotMapped]
        public IFormFile? ArquivoImagem { get; set; }
    }
}