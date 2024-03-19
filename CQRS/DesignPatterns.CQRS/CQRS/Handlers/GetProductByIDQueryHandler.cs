using DesignPatterns.CQRS.CQRS.Queries;
using DesignPatterns.CQRS.CQRS.Results;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context context;

        public GetProductByIDQueryHandler(Context context)
        {
            this.context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = context.Set<Product>().Find(query.ProductID);
            return new GetProductByIDQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
        }
    }
}
