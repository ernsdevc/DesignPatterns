using DesignPatterns.CQRS.CQRS.Commands;
using DesignPatterns.CQRS.CQRS.Handlers;
using DesignPatterns.CQRS.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQureyHandler getProductQureyHandler;
        private readonly CreateProductCommandHandler createProductCommandHandler;
        private readonly GetProductByIDQueryHandler getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler updateProductCommandHandler;

        public DefaultController(GetProductQureyHandler getProductQureyHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            this.getProductQureyHandler = getProductQureyHandler;
            this.createProductCommandHandler = createProductCommandHandler;
            this.getProductByIDQueryHandler = getProductByIDQueryHandler;
            this.removeProductCommandHandler = removeProductCommandHandler;
            this.getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            this.updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = getProductQureyHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult GetProduct(int id)
        {
            var values = getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
