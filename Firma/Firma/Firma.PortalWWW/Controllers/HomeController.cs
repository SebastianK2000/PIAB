using Firma.Data.Data;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Firma.Data.Data.Sklep;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var privacyModel = new Privacy
            {
                Title = "Privacy Policy",
            };
            ViewBag.ModelSupport = _context.Support.ToList();
            return View(privacyModel);
        }
        public async Task<IActionResult> Support()
        {
            var supportList = await _context.Support.ToListAsync();
            return View(supportList);
        }

        public async Task<IActionResult> Index()
        {
            var news = await _context.News
                .OrderBy(n => n.Position)
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(news);
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
            var model = _dbContext.Strona.ToList();
            return View(model);
        }

        public IActionResult Accessories()
        {
            return View();
        }
        public async Task<IActionResult> Orders()
        {
            var orders = await _context.Orders
                .Include(o => o.Product)
                .OrderByDescending(o => o.Date)
                .ToListAsync();

            ViewBag.ModelStrony = await _context.Strona
                .OrderBy(s => s.Pozycja)
                .ToListAsync();

            return View(orders);
        }

        public async Task<IActionResult> SelectProduct()
        {
            var products = await _context.Product.Include(p => p.Kind).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> CreateOrders(int? id)
        {
            var products = await _context.Product.ToListAsync();
            ViewBag.Products = new SelectList(products, "IdProduct", "Name");

            var order = new Orders
            {
                Number = "TEMP123",
                User = "",
                Email = "",
                Address = "",
                PaymentMethod = "",
                DeliveryMethod = "",
                Date = DateTime.Now,
                IdProducts = id ?? 0,
                Product = id != null ? await _context.Product.FindAsync(id) : null
            };

            return View(order);
        }

        [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> CreateOrders(Orders order)
{
    if (ModelState.IsValid)
    {
        var datePrefix = DateTime.Now.ToString("yyyyMMdd");
        var countToday = await _context.Orders.CountAsync(o => o.Date.Date == DateTime.Today);
        var uniqueNumber = $"ORD-{datePrefix}-{countToday + 1:D3}";
        order.Number = uniqueNumber;

        _context.Orders.Add(order); await _context.SaveChangesAsync();
        return RedirectToAction("Orders");
    }

    order.Product = await _context.Product.FindAsync(order.IdProducts);
    return View(order);
}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
