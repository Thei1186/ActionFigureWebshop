using System.Collections.Generic;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRep;

        public OrderService(IOrderRepository orderRep)
        {
            _orderRep = orderRep;
        }

        public Order CreateOrder(Order order)
        {
            return _orderRep.Creat(order);
        }

        public Order ReadOrder(int id)
        {
            return _orderRep.GetOrderById(id);
        }

        public Order DeleteOrder(Order order)
        {
            return _orderRep.Delete(order);
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRep.Update(order);
        }

        public List<Order> ReadAllOrders()
        {
            return _orderRep.ReadAll();
        }
    }
}