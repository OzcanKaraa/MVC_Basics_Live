using Microsoft.AspNetCore.Mvc;

namespace K01_Proje_Yapisi.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
