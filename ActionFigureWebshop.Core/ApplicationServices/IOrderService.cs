using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices
{
    public interface IOrderService
    {
        Order CreateOrder(Order order);
        Order ReadOrder(int id);
        Order DeleteOrder(Order order);
        Order UpdateOrder(Order order);
        List<Order> ReadAllOrders();
    }
}