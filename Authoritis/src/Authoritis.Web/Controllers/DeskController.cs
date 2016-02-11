using System.Security.Claims;
using System.Threading.Tasks;
using Authoritis.Web.Models;
using Authoritis.Web.ViewModels.Account;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace Authoritis.Web.Controllers
{
    public class DeskController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;

        public DeskController(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Tab = "Desk";
            var user = await GetCurrentUserAsync();

//            var query = new BookQueries();
//            var books = await query.GetAuthorBooksAsyc(user.Id);

//            return View(books);

            return View(null);
        }

        #region private methods

        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.FindByIdAsync(HttpContext.User.GetUserId());
        }

        #endregion
    }
}
