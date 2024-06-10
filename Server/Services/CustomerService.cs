using Crud_Test.Server.Interfaces;
using Crud_Test.Shared.Model;
using System.Text.Json;

namespace Crud_Test.Server.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customers;
        private readonly string _filePath;
        public CustomerService()
        {
            _filePath = "customers.json";
            _customers = LoadCustomersFromFile("customers.json");
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return _customers;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            customer.Id = _customers.Max(c => c.Id) + 1; // add to the max id
            _customers.Add(customer);
            await SaveCustomersToFile(_filePath, _customers);
            return customer;
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            var existingCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existingCustomer == null)
            {
                return false;
            }

            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Address = customer.Address;
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Active = customer.Active;

            await SaveCustomersToFile(_filePath, _customers);
            return true;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return false;
            }

            _customers.Remove(customer);
            await SaveCustomersToFile(_filePath, _customers);
            return true;
        }

        private List<Customer> LoadCustomersFromFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var json = System.IO.File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Customer>>(json);
            }

            return new List<Customer>();
        }

        private async Task SaveCustomersToFile(string filePath, List<Customer> customers)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(customers, options);
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}