namespace DesignPattern.Fascade.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
