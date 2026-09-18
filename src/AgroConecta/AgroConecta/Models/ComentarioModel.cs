using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AgroConecta.Models
{
    [Table("Comentarios")]
    public class ComentarioModel
    {
        [Key]
        public int Id { get; set; }

        public int TopicoId { get; set; }

        [ValidateNever]
        public required TopicoModel Topico { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o conteúdo do comentário!")]
        public required string Conteudo { get; set; }

        public int Curtidas { get; set; } = 0;

        public DateTime CriadoEm { get; set; }
    }
}
