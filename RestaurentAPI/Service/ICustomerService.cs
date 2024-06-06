using RestaurentAPI.Data;
using RestaurentAPI.Data.Entities;
using RestaurentAPI.Models;

namespace RestaurentAPI.Service
{
    public interface ICustomerService
    {
        ResponeModel<List<Customer>> GetCustomers();
    }

    public class CustomerService : ICustomerService
    {
        private readonly RestautantDbContext _context;

        public CustomerService(RestautantDbContext customerService)
        {
            _context = customerService;
        }

        public ResponeModel<List<Customer>> GetCustomers()
        {
            var result = _context.Customers.ToList();
            return new ResponeAPI<List<Customer>>(result);
        }
    }
}
