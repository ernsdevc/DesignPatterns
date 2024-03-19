using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, UpdateProductByIDQueryResult>
    {
        private readonly Context context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            this.context = context;
        }

        public async Task<UpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Products.FindAsync(request.ID);
            return new UpdateProductByIDQueryResult
            {
                ProductID = request.ID,
                ProductName = values.ProductName,
                Price = values.Price,
                Stock = values.Stock,
                StockType = values.StockType,
                Category = values.Category
            };
        }
    }
}
