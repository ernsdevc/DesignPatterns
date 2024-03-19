using DesignPatterns.CQRS.CQRS.Commands;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context context;

        public RemoveProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = context.Products.Find(command.ProductID);
            context.Products.Remove(values);
            context.SaveChanges();
        }
    }
}
