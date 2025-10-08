using Microsoft.AspNetCore.Mvc;

namespace WebApplication3HtmlHelperClasses.Controllers
{
    public class StronglyTypedHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string SignUp(int Id, string Name, string Address)
        {
            return Id + "-" + Name + "-" + Address; 
        }
    }
}
