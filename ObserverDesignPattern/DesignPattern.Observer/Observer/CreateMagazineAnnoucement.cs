using DesignPattern.Observer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Observer
{
    public class CreateMagazineAnnoucement : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnoucement(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + ' ' + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin Mart Sayısı 1 Martta evinize ulaştırılacaktır, konular Jüpiter Gezegeni ve Mars olacaktır"
            });
            context.SaveChanges();
        }
    }
}
