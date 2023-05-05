using K01_Proje_Yapisi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace K01_Proje_Yapisi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Topla()
        {
            int sayi1, sayi2, sonuc;

            sayi1 = 5;
            sayi2 = 6;
            sonuc = sayi1* sayi2;

            string mesaj = $"Yaptığınız işlemin sonucu {sonuc} dur...";

            return mesaj;
        }

        public string Urun()
        {
            return "...... Burası Urun metodu....";
        }
        public IActionResult Index()
        {
            string mesaj = "Bu bilgi ViewBag tarafından gelmiştir...";

            ViewBag.mesaj = mesaj;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Layout1()
        {
            return View();
        }

        public IActionResult Layout2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}