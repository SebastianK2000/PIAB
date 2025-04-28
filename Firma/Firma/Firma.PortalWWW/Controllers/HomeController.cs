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

        public async Task<IActionResult> Index()
        {
            ViewBag.ModelStrony =
                (
                    from strona in _context.Strona // dla ka¿dej strony z db
                    orderby strona.Pozycja // posortowanej wzglêdem pozycji
                    select strona // pobieramy strone
                ).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult iPhone()
        {
            return View();
        }

        public IActionResult Mac()
        {
            return View();
        }

        public IActionResult Watch()
        {
            return View();
        }
        public IActionResult Ipad()
        {
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
