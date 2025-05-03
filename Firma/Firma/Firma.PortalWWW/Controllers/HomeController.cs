using Firma.Data.Data;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirmaContext _context;
        public HomeController(ILogger<HomeController> logger, FirmaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ModelStrony =
                (
                    from strona in _context.Strona // dla ka¿dej strony z db
                    orderby strona.Pozycja // posortowanej wzglêdem pozycji
                    select strona // pobieramy strone
                ).ToList();

            if(id == null)
            {
                id = 1;
            }
            var item = await _context.Strona.FindAsync(id);

            return View(item);
        }

        public IActionResult Privacy()
        {
            ViewBag.ModelSupport =
            (
                from support in _context.Support
                select support
            ).ToList();

            return View();
        }

        public IActionResult Iphone()
        {
            ViewBag.ModelProducts =
            (
                from product in _context.Product
                where product.Kind != null && product.Kind.Name == "Iphone"
                select product
            ).ToList();

            return View();
        }

        public IActionResult Mac()
        {
            ViewBag.ModelProducts =
            (
                from product in _context.Product
                where product.Kind != null && product.Kind.Name == "Mac"
                select product
            ).ToList();

            return View();
        }

        public IActionResult Watch()
        {
            ViewBag.ModelProducts =
            (
                from product in _context.Product
                where product.Kind != null && product.Kind.Name == "Watch"
                select product
            ).ToList();

            return View();
        }
        public IActionResult Ipad()
        {

            ViewBag.ModelProducts =
            (
                from product in _context.Product
                where product.Kind != null && product.Kind.Name == "Ipad"
                select product
            ).ToList();

            return View();
        }

        public IActionResult Accessories()
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
