using System.Threading.Tasks;

namespace Authoritis.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
