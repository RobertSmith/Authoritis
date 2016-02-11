using System.Threading.Tasks;

namespace Authoritis.Web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
