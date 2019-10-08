using System.Dynamic;

namespace ActionFigureWebshop.Core.Entity
{
    public class OrderLine
    {
        public int ActionFigureId { get; set; }
        public ActionFigure ActionFigure { get; set; }

        public int OrderId { get; set; }
        public Order order { get; set; }

        public int Quantity { get; set; }
        public double PriceWhenBought { get; set; }

    }
}