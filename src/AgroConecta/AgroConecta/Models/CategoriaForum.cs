using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("CategoriasForum")]
    public class CategoriaForum
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public required string Desc { get; set; }
        public bool Ativo { get; set; } = true;
        [ValidateNever]
        public ICollection<TopicoModel> Topicos { get; set; } = new List<TopicoModel>();

    };
}
