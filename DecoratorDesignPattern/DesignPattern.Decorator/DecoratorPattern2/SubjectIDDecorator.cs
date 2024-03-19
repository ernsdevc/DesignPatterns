using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        Context context = new Context();
        private readonly ISendMessage sendMessage;

        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        public void SendMessageIDSubject(Message message)
        {
            if (message.Subject == "1")
            {
                message.Subject = "Toplantı";
            }
            else if (message.Subject == "2")
            {
                message.Subject = "Scrum Toplantısı";
            }
            else if (message.Subject == "3")
            {
                message.Subject = "Haftalık Değerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}
