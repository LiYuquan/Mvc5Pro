using MvcMusicStore.Models;
using MvcMusicStore.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product { Title = "Product" + i, Price = 1.2M * i });
            }
            var model = new ShoppingCartViewModel();
            model.Products = products;
            model.CartTotal = products.Sum(p => p.Price);
            model.Message = "Thanks for your business";
            return View(model);
        }
    }
}