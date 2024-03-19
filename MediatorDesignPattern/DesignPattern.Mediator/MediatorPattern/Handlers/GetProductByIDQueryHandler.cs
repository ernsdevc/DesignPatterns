using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context context;

        public GetProductByIDQueryHandler(Context context)
        {
            this.context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Products.FindAsync(request.ID);
            return new GetProductByIDQueryResult
            {
                ProductID = request.ID,
                ProductName = values.ProductName,
                Stock = values.Stock
            };
        }
    }
}
