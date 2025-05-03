using Firma.Data.Data;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            if (id == null)
            {
                id = 1;
            }

            var item = await _context.Strona.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        public async Task<IActionResult> Mac()
        {
            var produktyMac = await _context.Product
                .Where(p => p.Kind != null && p.Kind.Name == "Mac")
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(produktyMac);
        }

        public async Task<IActionResult> Ipad()
        {
            var produktyIpad = await _context.Product
                .Where(p => p.Kind != null && p.Kind.Name == "Ipad")
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(produktyIpad);
        }

        public async Task<IActionResult> Watch()
        {
            var produktyWatch = await _context.Product
                .Where(p => p.Kind != null && p.Kind.Name == "iWatch")
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(produktyWatch);
        }

        public async Task<IActionResult> Iphone()
        {
            var produktyIphone = await _context.Product
                .Where(p => p.Kind != null && p.Kind.Name == "Iphone")
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(produktyIphone);
        }

        public IActionResult Privacy()
        {
            ViewBag.ModelSupport = _context.Support.ToList();
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
