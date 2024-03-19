using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context context;

        public RemoveProductCommandHandler(Context context)
        {
            this.context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = context.Products.Find(request.ID);
            context.Products.Remove(values);
            await context.SaveChangesAsync();
        }
    }
}
