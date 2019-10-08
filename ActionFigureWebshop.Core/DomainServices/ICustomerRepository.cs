using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.DomainServices
{
    public interface ICustomerRepository
    {
        Customer Creat(Customer cust);
        List<Customer> ReadAll();

        Customer GetCustomerById(int id);

        Customer Update(Customer cust);
        Customer Delete(Customer cust);
    }
}