using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public Pedido? Pedido { get; set; }

        [Required(ErrorMessage = "Selecione uma forma de pagamento.")]
        public string TipoPagamento { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public DateTime AlteradoEm { get; set; } = DateTime.Now;
    }
}