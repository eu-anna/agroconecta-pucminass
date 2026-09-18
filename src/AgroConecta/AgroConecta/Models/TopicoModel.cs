using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AgroConecta.Models
{
    [Table("Topicos")]
    public class TopicoModel
    {
        [Key]
        public int Id { get; set; }

        public int CategoriaId { get; set; }

        [ValidateNever]
        public CategoriaForum? Categoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o título!")]
        public string Titulo { get; set; } = string.Empty;

        public string Conteudo { get; set; } = string.Empty;

        public int Curtidas { get; set; } = 0;

        public DateTime CriadoEm { get; set; }

        [ValidateNever]
        public ICollection<ComentarioModel> Comentarios { get; set; } = new List<ComentarioModel>();
    }
}