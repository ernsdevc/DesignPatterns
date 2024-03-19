using DesignPatterns.CQRS.CQRS.Queries;
using DesignPatterns.CQRS.CQRS.Results;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            this.context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = context.Products.Find(query.ProductID);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                ProductID = query.ProductID
            };
        }
    }
}
