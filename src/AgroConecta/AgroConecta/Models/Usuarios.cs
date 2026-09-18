using System.ComponentModel.DataAnnotations;

namespace AgroConecta.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Senha { get; set; } = null!;

        [Required]
        public string TipoUsuario { get; set; } = null!;

        public bool Ativo { get; set; } = true;

        public string? ResetToken { get; set; }

        public DateTime? ResetTokenExpiraEm { get; set; }
    }
}
