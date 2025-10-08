using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication3HtmlHelperClasses.Models;

namespace WebApplication3HtmlHelperClasses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string SendData(string uname, string password)
        {
            return $"data got {uname}, {password}";
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult showSignupData(IFormCollection data)
        {

            return View("Index");
        }
    }
}
