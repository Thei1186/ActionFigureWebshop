using System.Collections.Generic;

namespace ActionFigureWebshop.Core.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer OrderCustomer { get; set; }
        public List<ActionFigure> ActionFigures { get; set; }
        public double TotalOrderPrice { get; set; }
    }
}