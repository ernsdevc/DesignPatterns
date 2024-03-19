using DesignPattern.Fascade.DAL;

namespace DesignPattern.Fascade.FascadePatern
{
    public class AddOrder
    {
        Context context = new Context();

        public void AddNewOrder(Order order)
        {
            order.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
