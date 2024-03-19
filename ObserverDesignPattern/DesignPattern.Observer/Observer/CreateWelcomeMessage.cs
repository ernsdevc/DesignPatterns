using DesignPattern.Observer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Observer
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + ' ' + appUser.Surname,
                Content = "Dergi Bültenimize Kayıt Olduğunuz İçin Teşekkür Ederiz, Dergilerimize Web Sitemizden Ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
