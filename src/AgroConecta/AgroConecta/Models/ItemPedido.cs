using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("ItensPedido")]
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário estar atrelado a um pedido")]
        public int Pedido_id { get; set; }


        [ForeignKey("Pedido_id")]
        public virtual Pedido? Pedido { get; set; }

        [Required(ErrorMessage = "Necessário estar atrelado a um produto.")]
        public int Produto_id { get; set; }


        [ForeignKey("Produto_id")]
        public Produto? Produto { get; set; }

        public int? Quantidade { get; set; }
    }
}
