using DesignPattern.Fascade.DAL;
using DesignPattern.Fascade.FascadePatern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Fascade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult StartOrderDetail(int customerID, int orderID)
        {
            var values = new OrderDetail
            {
                CustomerID = customerID,
                OrderID = orderID
            };

            return View(values);
        }

        [HttpPost]
        public IActionResult StartOrderDetail(int customerID, int productID, int orderID, int productCount, decimal productPrice)
        {
            OrderFascade order = new OrderFascade();

            order.CompleteOrderDetail(customerID, productID, orderID, productCount, productPrice);
            return RedirectToAction("OrderList");
        }

        [HttpGet]
        public IActionResult StartOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartOrder(int customerID)
        {
            OrderFascade order = new OrderFascade();

            int orderID = order.CompleteOrder(customerID);
            return RedirectToAction("StartOrderDetail", new { customerID, orderID});
        }

        public IActionResult OrderList()
        {
            var values = (from o in context.Orders
                          join c in context.Customers on o.CustomerID equals c.CustomerID
                          select new
                          {
                              o.OrderID,
                              o.CustomerID,
                              c.CustomerName,
                              c.CustomerSurname
                          }).ToList();
            ViewBag.v = values;
            return View();
        }

        public IActionResult OrderDetail(int orderID)
        {
            var values = (from od in context.OrderDetails
                          join o in context.Orders on od.OrderID equals o.OrderID
                          join c in context.Customers on o.CustomerID equals c.CustomerID
                          join p in context.Products on od.ProductID equals p.ProductID
                          where od.OrderID == orderID
                          select new
                          {
                              od.OrderDetailID,
                              od.OrderID,
                              od.CustomerID,
                              p.ProductID,
                              CustomerNameSurname = c.CustomerName + ' ' + c.CustomerSurname,
                              p.ProductName,
                              od.ProductCount,
                              od.ProductPrice,
                              od.ProductTotalPrice
                          }).ToList();
            ViewBag.v = values;
            return View();
        }
    }
}
