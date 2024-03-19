using DesignPatterns.CQRS.CQRS.Commands;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context context;

        public UpdateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Description = command.Description;
            context.SaveChanges();
        }
    }
}
