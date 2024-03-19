using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier notifier;
        Context context = new Context();

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            this.notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.Subject = "Günlük Sabah Toplantısı";
            notifier.Creator = "Scrum Master";
            notifier.Type = "Private Team";
            notifier.Channel = "Gmail-Outlook";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }

        public override void CreateNotifier(Notifier notifier)
        {
            base.CreateNotifier(notifier);
            SendMailNotify(notifier);
        }
    }
}
