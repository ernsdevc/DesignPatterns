using DesignPattern.Fascade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Fascade.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
