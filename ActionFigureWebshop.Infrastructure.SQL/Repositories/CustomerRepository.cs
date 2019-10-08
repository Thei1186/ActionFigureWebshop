using System.Collections.Generic;
using System.Linq;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActionFigureWebshop.Infrastructure.SQL.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ActionFigureShopContext _ShopContext;
        public CustomerRepository(ActionFigureShopContext context)
        {
            _ShopContext = context;
        }

        public Customer Creat(Customer cust)
        {
            _ShopContext.Attach(cust).State = EntityState.Added;
            _ShopContext.SaveChanges();
            return cust;
        }

        public List<Customer> ReadAll()
        {
            return _ShopContext.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _ShopContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer Update(Customer cust)
        {
            _ShopContext.Attach(cust).State = EntityState.Modified;
            _ShopContext.SaveChanges();
            return cust;
        }

        public Customer Delete(Customer cust)
        {
            var customerToRemoved = _ShopContext.Remove(cust).Entity;
            _ShopContext.SaveChanges();
            return customerToRemoved;
        }
    }
}