using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
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
            List<ProductItem> urunKayitlari = new List<ProductItem>();
            urunKayitlari.Add(new ProductItem { title = "Supurge", startCount = 5, oldPrice = 100, price = 12, imageUrl = "https://cdn.akakce.com/fantom/fantom-eco-wf-4700-2200-w-islak-kuru-supurge-z.jpg", isSale = true });
            urunKayitlari.Add(new ProductItem { title = "Kopek Kemigi", startCount = 2, oldPrice = 20, price = 10, imageUrl = "https://m.media-amazon.com/images/I/61ayLJnlwYL.jpg", isSale = false });
            urunKayitlari.Add(new ProductItem { title = "Kitap", startCount = 4, oldPrice = 23, price = 21, imageUrl = "https://cdn.cimri.io/image/1200x1200/kitapykkitaplarfiyatlar_126253285.jpg", isSale = false });           
			urunKayitlari.Add(new ProductItem { title = "Salatalik", startCount = 2, oldPrice = 12, price = 4, imageUrl = "https://static.ticimax.cloud/30771/uploads/urunresimleri/buyuk/salatalik-kg-60c4.jpg", isSale = true });
            urunKayitlari.Add(new ProductItem { title = "Ikili Bounty", startCount = 1, oldPrice = 12, price = 3, imageUrl = "https://www.bigbasket.com/media/uploads/p/l/40258172-7_1-bounty-coconut-chocolate-bar-tender-moist-centre.jpg", isSale = true });
            urunKayitlari.Add(new ProductItem { title = "Snickers", startCount = 5, oldPrice = 11, price = 10, imageUrl = "https://images.migrosone.com/sanalmarket/product/07040020/07040020-f57ff7-1650x1650.JPG", isSale = false });
            urunKayitlari.Add(new ProductItem { title = "Kremali Biskuvi", startCount = 5, oldPrice = 53, price = 23, imageUrl = "https://i.redd.it/doritos-cubun-beskot-parawla-v0-a5u002ygh5ra1.jpg?width=450&format=pjpg&auto=webp&s=06ec3adaa09fa43eba104d2476be19bc23533102", isSale = true });
            urunKayitlari.Add(new ProductItem { title = "Doritos Nacho", startCount = 1, oldPrice = 12, price = 10, imageUrl = "https://images.migrosone.com/sanalmarket/product/05081220/05081220-47d24e-1650x1650.jpg", isSale = true });


            return View(urunKayitlari);
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