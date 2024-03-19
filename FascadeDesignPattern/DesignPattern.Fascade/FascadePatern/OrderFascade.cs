using DesignPattern.Fascade.DAL;

namespace DesignPattern.Fascade.FascadePatern
{
    public class OrderFascade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrderDetail(int customerID,int productID, int orderID,int productCount,decimal productPrice)
        {
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.OrderID = orderID;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductTotalPrice = productCount * productPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productID, productCount);
        }

        public int CompleteOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
            return order.OrderID;
        }
    }
}
