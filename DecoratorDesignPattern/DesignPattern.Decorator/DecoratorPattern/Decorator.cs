using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        Context context = new Context();
        private readonly INotifier notifier;

        public Decorator(INotifier notifier)
        {
            this.notifier = notifier;
        }

        virtual public void CreateNotifier(Notifier notifier)
        {
            notifier.Creator = "Admin";
            notifier.Subject = "Toplantı";
            notifier.Type = "Public";
            notifier.Channel = "Whatsapp";
            this.notifier.CreateNotifier(notifier);
        }
    }
}
