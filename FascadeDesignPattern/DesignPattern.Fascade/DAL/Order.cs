namespace DesignPattern.Fascade.DAL
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
