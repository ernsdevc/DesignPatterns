using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        Context context = new Context();
        private readonly ISendMessage sendMessage;

        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        public void SendMessageByEncryptContent(Message message)
        {
            message.Sender = "Takım Lideri";
            message.Reciever = "Yazılım Ekibi";
            message.Content = "Saat 17:00' de Publish yapılacak.";
            message.Subject = "Publish";
            string data = "";
            data = message.Content;
            char[] chars = data.ToCharArray();
            string encryptedData = "";
            foreach (var item in chars)
            {
                encryptedData += Convert.ToChar(item + 3).ToString();
            }
            message.Content += encryptedData;
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptContent(message);
        }
    }
}
