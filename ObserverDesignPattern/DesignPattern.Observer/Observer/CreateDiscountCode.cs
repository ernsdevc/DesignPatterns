using DesignPattern.Observer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Observer
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGIMART",
                DiscountAmount = 35,
                DiscounCodeStaus = true
            });
            context.SaveChanges();
        }
    }
}
