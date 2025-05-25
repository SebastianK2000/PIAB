//using Firma.Data.Data;
//using Microsoft.AspNetCore.Mvc;
//using Firma.Data.Data.Sklep;

//namespace Firma.PortalWWW.Controllers
//{
//    public class CartController : Controller
//    {
//        private readonly FirmaContext _context;

//        public CartController(FirmaContext context)
//        {
//            _context = context;
//        }

//        [HttpPost]
//        public IActionResult AddToCart(int productId)
//        {
//            var product = _context.Product.FirstOrDefault(p => p.IdProduct == productId);
//            if (product == null)
//                return NotFound();

//            List<Product> cart = HttpContext.Session.GetObjectFromJson<List<Product>>("Cart") ?? new List<Product>();
//            cart.Add(product);
//            HttpContext.Session.SetObjectAsJson("Cart", cart);

//            return RedirectToAction("Index", "Cart");
//        }

//        public IActionResult Index()
//        {
//            var cart = HttpContext.Session.GetObjectFromJson<List<Product>>("Cart") ?? new List<Product>();
//            return View(cart);
//        }
//    }
//}
