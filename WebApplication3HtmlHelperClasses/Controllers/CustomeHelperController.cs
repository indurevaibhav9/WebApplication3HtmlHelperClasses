using Microsoft.AspNetCore.Mvc;

namespace WebApplication3HtmlHelperClasses.Controllers
{
    public class CustomeHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
