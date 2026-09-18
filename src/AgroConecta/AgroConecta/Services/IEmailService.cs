using System.Threading.Tasks;

namespace AgroConecta.Services
{
    public interface IEmailService
    {
        Task EnviarEmailAsync(string para, string assunto, string mensagem);
    }
}
