﻿namespace DesignPattern.Mediator.MediatorPattern.Results
{
    public class UpdateProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string StockType { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
