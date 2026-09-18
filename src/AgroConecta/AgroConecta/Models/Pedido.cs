using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgroConecta.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario? Usuario { get; set; }

        public StatusPedido Status { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public string EnderecoEntrega { get; set; } = string.Empty;

        public string NomeCliente { get; set; } = string.Empty;

        public DateTime? DataFechamento { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public DateTime AlteradoEm { get; set; } = DateTime.Now;

        public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        [NotMapped]
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato de CEP inválido (00000-000).")]
        public string Cep { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "O logradouro é obrigatório.")]
        public string Logradouro { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "O número é obrigatório.")]
        public string Numero { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "O bairro é obrigatório.")]
        public string Bairro { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "A cidade é obrigatória.")]
        public string Cidade { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "O estado é obrigatório.")]
        public string Estado { get; set; } = string.Empty;

        public virtual Avaliacao? Avaliacao { get; set; }
    }

    public enum StatusPedido
    {
        Em_aberto,
        Pedido_criado,
        Aguardando_pagamento,
        Em_processamento,
        Enviado,
        Em_rota_de_entrega,
        Entregue,
        Cancelado
    }
}
