using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Authoritis.Web.Cache;
using Authoritis.Web.Models;
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

            return View(new List<BookModel>());
        }

        // GET: /Desk/NewBook
        [HttpGet]
        public async Task<ActionResult> NewBook()
        {
            ViewBag.Tab = "Desk";
            ViewBag.Genres = GenreCache.GetAll();
            ViewBag.Languages = LanguagesCache.GetAll();

            var user = await GetCurrentUserAsync();
            var newBookKey = Guid.NewGuid(); //_service.StartANewBook(user);

            return RedirectToAction("Book", "Desk", new { key = newBookKey });
        }

        // GET: /Desk/Book
        public async Task<ActionResult> Book(string key, string message)
        {
            ViewBag.Key = key;
            ViewBag.Tab = "Desk";
            ViewBag.SubTab = "Book";
            ViewBag.Genres = GenreCache.GetAll();
            ViewBag.Languages = LanguagesCache.GetAll();

            if (!string.IsNullOrEmpty(message))
                ViewBag.StatusMessage = message;

            return View(new BookModel());// _service.GetBookByKey(key));
        }

        #region private methods

        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.FindByIdAsync(HttpContext.User.GetUserId());
        }

        #endregion
    }
}
