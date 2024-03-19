using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context context;

        public CreateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                Price = request.Price,
                Stock = request.Stock,
                StockType = request.StockType,
                Category = request.Category,
            });
            await context.SaveChangesAsync();
        }
    }
}
