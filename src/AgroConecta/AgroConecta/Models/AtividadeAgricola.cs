using System.ComponentModel.DataAnnotations;

namespace AgroConecta.Models
{
    public class AtividadeAgricola
    {
        public int Id { get; set; }

        [Display(Name = "Propriedade")]
        public int PropriedadeId { get; set; }

        public Propriedade? Propriedade { get; set; }

        [Display(Name = "Cultura")]
        public int CulturaId { get; set; }

        public Cultura? Cultura { get; set; }

        [Display(Name = "Data de Início")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Fim")]
        public DateTime? DataFim { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
    }
}