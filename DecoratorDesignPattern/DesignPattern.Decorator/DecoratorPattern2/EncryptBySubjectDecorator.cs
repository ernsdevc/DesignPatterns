using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptBySubjectDecorator:Decorator
    {
        Context context = new Context();
        private readonly ISendMessage sendMessage;

        public EncryptBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            this.sendMessage = sendMessage;
        }

        public void SendMessageByEncryptSubject(Message message)
        {
            string data = "";
            data = message.Subject;
            char[] chars = data.ToCharArray();
            string encryptedData = "";
            foreach (var item in chars)
            {
                encryptedData += Convert.ToChar(item+3).ToString();
            }
            message.Subject = encryptedData;
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptSubject(message);
        }
    }
}
