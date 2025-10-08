using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApplication3HtmlHelperClasses.Models;

namespace WebApplication3HtmlHelperClasses.Controllers
{
    public class TemplatedHelperController : Controller
    {
       
        public IActionResult Index()
        {
            Student student = new Student();
            return View(student);
        }

        public string SignUp()
        {
            string id = Request.Form["Id"];
            string name = Request.Form["Name"];
            return id + " " + name;
        }
    }
}
