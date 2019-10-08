using System;
using System.Collections.Generic;

namespace ActionFigureWebshop.Core.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer OrderCustomer { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public double TotalOrderPrice { get; set; }
    }
}