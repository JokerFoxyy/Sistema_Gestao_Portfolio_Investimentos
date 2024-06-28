using System.Net.Mail;
using System.Net;

namespace SistemaGestaoPortfolioInvestimentos.Services
{
    public class EmailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly string _fromAddress;

        public EmailService(string smtpServer, int port, string fromAddress, string password)
        {
            _smtpClient = new SmtpClient(smtpServer)
            {
                Port = port,
                Credentials = new NetworkCredential(fromAddress, password),
                EnableSsl = true,
            };
            _fromAddress = fromAddress;
        }

        public async Task SendEmailAsync(string toAddress, string subject, string body)
        {
            var mailMessage = new MailMessage(_fromAddress, toAddress, subject, body);
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
