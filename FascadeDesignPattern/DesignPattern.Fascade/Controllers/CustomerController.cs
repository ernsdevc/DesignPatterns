using DesignPattern.Fascade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Fascade.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public IActionResult CustomerList()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
    }
}
