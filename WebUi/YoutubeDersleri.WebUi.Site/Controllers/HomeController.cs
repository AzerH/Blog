using Microsoft.AspNetCore.Mvc;

namespace WebUi.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
