using Microsoft.AspNetCore.Mvc;

namespace K01_Proje_Yapisi.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
