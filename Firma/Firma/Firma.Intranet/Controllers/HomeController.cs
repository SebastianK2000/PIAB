using System.Diagnostics;
using Firma.Intranet.Models;
using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.Intranet.Controllers
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            var page = await _context.Privacy.FirstOrDefaultAsync(p => p.PageName == "Privacy");
            ViewBag.ModelSupport = await _context.Support.ToListAsync();
            return View(page);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
