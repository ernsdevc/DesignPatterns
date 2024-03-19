using DesignPatterns.CQRS.CQRS.Results;
using DesignPatterns.CQRS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Handlers
{
    public class GetProductQureyHandler
    {
        private readonly Context context;

        public GetProductQureyHandler(Context context)
        {
            this.context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Price = x.Price,
                Name = x.Name,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}
