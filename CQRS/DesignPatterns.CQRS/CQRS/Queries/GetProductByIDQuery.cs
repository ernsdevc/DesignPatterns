using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
