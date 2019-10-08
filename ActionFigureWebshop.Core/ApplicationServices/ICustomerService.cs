using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer cust);
        Customer ReadCustomer(int id);
        Customer DeleteCustomer(Customer cust);
        Customer UpdateCustomer(Customer cust);
        List<Customer> ReadAllCustomer();
    }
}