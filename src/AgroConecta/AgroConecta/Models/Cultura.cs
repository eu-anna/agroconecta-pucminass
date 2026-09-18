using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AgroConecta.Models
{
    public class Cultura
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cultura é obrigatório.")]
        public string NomeCultura { get; set; } = null!;

        [Required(ErrorMessage = "A área de plantio é obrigatória.")]
        public double AreaPlantio { get; set; }

        [Required(ErrorMessage = "A data de plantio é obrigatória.")]
public DateTime? DataPlantio { get; set; }

[Required(ErrorMessage = "A data prevista de colheita é obrigatória.")]
public DateTime? DataPrevistaColheita { get; set; }

[Required(ErrorMessage = "A data de irrigação é obrigatória.")]
public DateTime? DataIrrigacao { get; set; }

        [Required(ErrorMessage = "O status é obrigatório.")]
        public string Status { get; set; } = null!;

        [Required(ErrorMessage = "A propriedade é obrigatória.")]
        public int PropriedadeId { get; set; }

        [ValidateNever]
        public Propriedade? Propriedade { get; set; }
    }
}
