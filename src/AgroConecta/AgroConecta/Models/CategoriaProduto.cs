using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("Categorias")]
    public class CategoriaProduto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [MaxLength(50)]
        public required string Nome { get; set; }

        [MaxLength(255)]
        public string Desc { get; set; } = string.Empty;

        public bool Ativo { get; set; } = true;

        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
