using Firma.Data.Data;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Firma.Data.Data.Sklep;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirmaContext _context;
        private readonly FirmaContext _dbContext;

        public HomeController(ILogger<HomeController> logger, FirmaContext context)
        {
            _logger = logger;
            _context = context;
            _dbContext = context;
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
        public async Task<IActionResult> Support()
        {
            var supportList = await _context.Support.ToListAsync();
            return View(supportList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Support support)
        {
            if (ModelState.IsValid)
            {
                _context.Add(support);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Support));
            }

            return View(support);
        }

        public IActionResult Odnoœniki()
        {
            // Ensure _dbContext is properly configured and injected
            var model = _dbContext.Strona.ToList(); // Fetch data from the database
            return View(model); // Pass the model to the view
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
