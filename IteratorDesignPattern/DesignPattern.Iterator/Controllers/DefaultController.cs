using DesignPattern.Iterator.Itaretor;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> routes = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Almanya", City = "Berlin", VisitPlace = "Berlin Kapısı" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Fransa", City = "Paris", VisitPlace = "Eyfel" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "İtalya", City = "Venedik", VisitPlace = "Gondol" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "İtalya", City = "Roma", VisitPlace = "Kolezyum" });
            visitRouteMover.AddVisitRoute(new VisitRoute { Country = "Çek Cumhuriyeti", City = "Prag", VisitPlace = "Meydan" });

            var iterator = visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                routes.Add(iterator.CurrentItem.Country + ' ' + iterator.CurrentItem.City + ' ' + iterator.CurrentItem.VisitPlace);
            }

            ViewBag.v = routes;

            return View();
        }
    }
}
