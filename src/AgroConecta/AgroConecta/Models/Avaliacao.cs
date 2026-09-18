using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Index(nameof(PedidoId), IsUnique = true)]
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        public string? Conteudo { get; set; }

        [Required]
        [Range(1, 5)]
        public int Classificacao { get; set; }

        [Required]
        public DateTime CriadoEm { get; set; }

        public DateTime? EditadoEm { get; set; }   

        [Required]
        public int PedidoId { get; set; }

        [ForeignKey(nameof(PedidoId))]
        public virtual Pedido? Compra { get; set; }
    }
}