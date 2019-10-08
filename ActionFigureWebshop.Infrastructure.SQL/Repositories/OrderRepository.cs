using System.Collections.Generic;
using System.Linq;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActionFigureWebshop.Infrastructure.SQL.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly ActionFigureShopContext _ShopContext;

        public OrderRepository(ActionFigureShopContext context)
        {
            _ShopContext = context;
        }

        public Order Creat(Order order)
        {
            _ShopContext.Attach(order).State = EntityState.Added;
            _ShopContext.SaveChanges();
            return order;
        }

        public List<Order> ReadAll()
        {
            return _ShopContext.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _ShopContext.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public Order Update(Order order)
        {
            _ShopContext.Attach(order).State = EntityState.Modified;
            _ShopContext.SaveChanges();
            return order;
        }

        public Order Delete(Order order)
        {
            var orderToRemove = _ShopContext.Remove(order).Entity;
            _ShopContext.SaveChanges();
            return orderToRemove;
        }
    }
}