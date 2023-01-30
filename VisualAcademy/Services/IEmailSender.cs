using System.Threading.Tasks;

namespace VisualAcademy.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
