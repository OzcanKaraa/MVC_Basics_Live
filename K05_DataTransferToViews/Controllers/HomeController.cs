using K05_DataTransferToViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace K05_DataTransferToViews.Controllers
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
            // ViewBag
            // Controller --> View veri taşımak için kullanılıyor. Bilinmesi gereken ViewBag kullanımında tersi mümkün değil (View --> Controllera ViewBag ile veri taşınamıyor. Diğer bir olay ViewBag ile taşınan bilginin herhangi bir Redirect veya Post olması durumunda ViewBag içeriği temizleniyor. Bir ViewBag değişgenine eğer birden fazla atama yapılırsa en son yapılan atama geçerli oluyor.

            ViewBag.Message = "Bu ViewBag ile taşınan bir veriyi göstermektedir...";

            // ViewData
            // ViewBag ile benzerdir.Fakat yapısı itibariyle Dictionary mantığı ile çalışır. Dictionary Key-Value mantığıyla çalışır. Key değeri olarak string tanımlamayı kabul eder. Bu gönderilen ViewData içeriğini kullanmadan önce bir Tip dönüşümü (TypeCast) işlemine tabi tutulması gerekir.

            // Örnek sınıfımızdan yararlanarak bir veri kümesini Index sayfasına gönderme

            List<Author> authorList = new List<Author>();

            authorList.Add(new Author() { AuthorID = 1, AuthorName = "Stephen King" });
            authorList.Add(new Author() { AuthorID = 2, AuthorName = "Alexander Dumas" });
            authorList.Add(new Author() { AuthorID = 3, AuthorName = "Honores de Balzac" });
            authorList.Add(new Author() { AuthorID = 4, AuthorName = "Charles Dickens" });

            ViewBag.Message2 = "Burası ViewData ile taşınan veridir..";

            ViewData["Authors"]= authorList;

            // TempData
            // ViewData ile benzer yapıdadır.

            ViewBag.Message3 = "TempData ile gelen bilgi...";
            TempData["Name"] = "Ümit Karaçivi";
            TempData["Age"] = 58;

            TempData.Keep();

            return View();
        }

        public IActionResult Privacy()
        {
            string Name;
            int Age;

            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                Age = int.Parse(TempData["Age"].ToString());
            }

            // TempData'nın kullanım/yaşam ömrü tek seferlik.Yani bir kere kullanıldıktan ve herhangi bir post işlemi olduğunda içeriğini kaybediyor. Dolayısı ile veriyi kaybediyoruz..

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

public class Author
{
    public int AuthorID { get; set; }
    public string AuthorName { get; set; }
}