using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.Reciever = "Everyone";
            message.Sender = "Admin";
            message.Content = "Merhaba bu bir toplantı mesajıdır";
            message.Subject = "Toplantı";
            sendMessage.SendMessage(message);
        }
    }
}
