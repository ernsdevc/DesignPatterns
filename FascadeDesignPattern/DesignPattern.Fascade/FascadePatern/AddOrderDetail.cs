using DesignPattern.Fascade.DAL;

namespace DesignPattern.Fascade.FascadePatern
{
    public class AddOrderDetail
    {
        Context context = new Context();

        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            context.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
