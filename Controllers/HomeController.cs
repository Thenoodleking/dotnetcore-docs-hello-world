using Microsoft.AspNetCore.Mvc;

namespace LSP_HOME.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chatbot()
        {
            return View();
        }
    }
}
