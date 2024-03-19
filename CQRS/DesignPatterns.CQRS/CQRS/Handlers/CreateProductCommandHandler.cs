using DesignPatterns.CQRS.CQRS.Commands;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context context;

        public CreateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            context.Products.Add(new Product
            {
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Status = true,
                Stock =command.Stock
            });

            context.SaveChanges();
        }
    }
}
