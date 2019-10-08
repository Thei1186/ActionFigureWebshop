using System.Collections.Generic;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _custRepo;

        public CustomerService(ICustomerRepository custRepo)
        {
            _custRepo = custRepo;
        }
        public Customer CreateCustomer(Customer cust)
        {
            return _custRepo.Creat(cust);
        }

        public Customer ReadCustomer(int id)
        {
            return _custRepo.GetCustomerById(id);
        }

        public Customer DeleteCustomer(Customer cust)
        {
            return _custRepo.Delete(cust);
        }

        public Customer UpdateCustomer(Customer cust)
        {
            return _custRepo.Update(cust);
        }

        public List<Customer> ReadAllCustomer()
        {
            return _custRepo.ReadAll();
        }
    }
}