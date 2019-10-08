using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.DomainServices
{
    public interface IOrderRepository
    {
        Order Creat(Order order);
        List<Order> ReadAll();

        Order GetOrderById(int id);

        Order Update(Order order);
        Order Delete(Order order);
    }
}