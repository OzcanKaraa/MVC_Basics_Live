using K07_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace K07_Models.Controllers
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
            var cars = new List<Car>()
            {
                new Car(){ Id=1, Brand="Mercedes", Family="C200", Year=2000},
                new Car(){ Id=2, Brand="Bugatti", Family="Veyron", Year=2020},
                new Car(){ Id=3, Brand="Volvo", Family="XC70", Year=1995},
                new Car(){ Id=4, Brand="Renault", Family="Alpine", Year=2005},
            };

            return View(cars); // Listem View tarafına gönderiliyor
        }

        public IActionResult Movie()
        {
            var movies = new List<Movie>()
            {
                new Movie(){ Id=1, Title="Rüzgar gibi geçti", Description="Efsane bir film" , Year=1955},
                new Movie(){ Id=2, Title="İyi Kötü Çirkin", Description="Efsane bir film 2" , Year=1960}
            };

            return View(movies); // Listem View tarafına gönderiliyor
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
    }
}