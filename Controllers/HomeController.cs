using Microsoft.AspNetCore.Mvc;

namespace Mission5.Controllers
{
    // Controllers handle requests and decide which View to return
    public class HomeController : Controller
    {
        // This action runs when the user goes to /
        public IActionResult Index()
        {
            // Returns Views/Home/Index.cshtml
            return View();
        }

        // This action runs when the user goes to /Home/Calculator
        public IActionResult Calculator()
        {
            // Returns Views/Home/Calculator.cshtml
            return View();
        }
    }
}
