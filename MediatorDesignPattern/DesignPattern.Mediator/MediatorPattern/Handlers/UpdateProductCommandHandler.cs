using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context context;

        public UpdateProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = context.Products.Find(request.ProductID);
            values.ProductName = request.ProductName;
            values.Price = request.Price;
            values.Stock = request.Stock;
            values.StockType = request.StockType;
            values.Category = request.Category;
            await context.SaveChangesAsync();
        }
    }
}
