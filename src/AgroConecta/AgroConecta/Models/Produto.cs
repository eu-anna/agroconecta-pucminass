using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Produtor")]
        [Required(ErrorMessage = "O produto deve estar vinculado a um produtor.")]
        public int Produtor_id { get; set; }

        [ForeignKey("Produtor_id")]
        public virtual Usuario? Produtor { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        [MaxLength(50, ErrorMessage = "O nome do produto deve ter no máximo 50 caracteres.")]
        public required string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Por favor, informe a descrição do produto.")]
        public required string Descricao { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Informe a categoria do produto.")]
        public int Categoria_id { get; set; }

        [ForeignKey("Categoria_id")]
        public virtual CategoriaProduto? Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço unitário do produto.")]
        [Display(Name = "Preço")]
        public float Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe o estoque do produto.")]
        public int Estoque { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? Imagem { get; set; }

        [Required]
        [Range(0, 1)]
        public int Ativo { get; set; } = 1;

        [Display(Name = "Cadastrado em")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CriadoEm { get; set; }
    }
}