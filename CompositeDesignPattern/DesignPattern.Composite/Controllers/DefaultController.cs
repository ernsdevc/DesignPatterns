using DesignPattern.Composite.CompositePattern;
using DesignPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context context;

        public DefaultController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var categories = context.Categories.Include(x => x.Products).ToList();
            var values = Rekursive(categories, new Category { CategoryID = 0, CategoryName = "FirstCategory"}, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Rekursive(List<Category> categories, Category category, ProductComposite firstComposite, ProductComposite composite = null)
        {
            categories.Where(x => x.UpperCategoryID == category.CategoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);
                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });

                if (composite != null)
                {
                    composite.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }

                Rekursive(categories, y, firstComposite, productComposite);
            });

            return firstComposite;
        }
    }
}
