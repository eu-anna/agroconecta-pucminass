using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AgroConecta.Services
{
    public class EmailService
    {
        private readonly string _smtpHost = "smtp.example.com";
        private readonly int _smtpPort = 587;
        private readonly string _smtpUser = "user@example.com";
        private readonly string _smtpPassword = "password";

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                using var message = new MailMessage();
                message.From = new MailAddress("hello@demomailtrap.co", "AgroConecta");
                message.To.Add(toEmail);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                using var smtpClient = new SmtpClient(_smtpHost, _smtpPort)
                {
                    Credentials = new NetworkCredential(_smtpUser, _smtpPassword),
                    EnableSsl = true
                };

                await smtpClient.SendMailAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while sending email: {0}", ex);
                throw;
            }
        }
    }
}
