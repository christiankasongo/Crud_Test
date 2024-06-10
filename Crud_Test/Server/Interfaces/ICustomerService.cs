using Crud_Test.Shared.Model;

namespace Crud_Test.Server.Interfaces
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer> AddCustomer(Customer customer);
        public Task<bool> UpdateCustomer(Customer customer);
        public Task<bool> DeleteCustomer(int id);
    }
}