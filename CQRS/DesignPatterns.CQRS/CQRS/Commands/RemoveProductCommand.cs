using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.CQRS.Commands
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
