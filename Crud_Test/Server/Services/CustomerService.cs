using Crud_Test.Server.Interfaces;
using Crud_Test.Shared.Model;

namespace Crud_Test.Server.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer
            {
                Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Email = "john.doe@example.com",
                Phone = 1234567890, Active = true
            });
            customers.Add(new Customer
            {
                Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St",
                Email = "jane.smith@example.com", Phone = 9876543210, Active = false
            });
            customers.Add(new Customer
            {
                Id = 3, FirstName = "Alice", LastName = "Johnson", Address = "789 Maple Ave",
                Email = "alice.johnson@example.com", Phone = 5551234567, Active = true
            });
            customers.Add(new Customer
            {
                Id = 4, FirstName = "Bob", LastName = "Brown", Address = "321 Oak St", Email = "bob.brown@example.com",
                Phone = 5559876543, Active = true
            });
            customers.Add(new Customer
            {
                Id = 5, FirstName = "Charlie", LastName = "Davis", Address = "654 Pine St",
                Email = "charlie.davis@example.com", Phone = 5555678901, Active = false
            });
            customers.Add(new Customer
            {
                Id = 6, FirstName = "Emily", LastName = "Wilson", Address = "987 Birch Ave",
                Email = "emily.wilson@example.com", Phone = 5556789012, Active = true
            });
            customers.Add(new Customer
            {
                Id = 7, FirstName = "Frank", LastName = "Miller", Address = "159 Cedar St",
                Email = "frank.miller@example.com", Phone = 5557890123, Active = true
            });
            customers.Add(new Customer
            {
                Id = 8, FirstName = "Grace", LastName = "Lee", Address = "753 Spruce St",
                Email = "grace.lee@example.com", Phone = 5558901234, Active = false
            });
            customers.Add(new Customer
            {
                Id = 9, FirstName = "Henry", LastName = "Clark", Address = "852 Willow St",
                Email = "henry.clark@example.com", Phone = 5559012345, Active = true
            });
            customers.Add(new Customer
            {
                Id = 10, FirstName = "Isabella", LastName = "White", Address = "456 Aspen St",
                Email = "isabella.white@example.com", Phone = 5550123456, Active = true
            });

            return customers;
        }

        // public void GetCustomers()
        // {
        //     customers.Add(new Customer { Id = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", Email = "john.doe@example.com", Phone = 1234567890, Active = true });
        //     customers.Add(new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", Email = "jane.smith@example.com", Phone = 9876543210, Active = false });
        //     customers.Add(new Customer { Id = 3, FirstName = "Alice", LastName = "Johnson", Address = "789 Maple Ave", Email = "alice.johnson@example.com", Phone = 5551234567, Active = true });
        //     customers.Add(new Customer { Id = 4, FirstName = "Bob", LastName = "Brown", Address = "321 Oak St", Email = "bob.brown@example.com", Phone = 5559876543, Active = true });
        //     customers.Add(new Customer { Id = 5, FirstName = "Charlie", LastName = "Davis", Address = "654 Pine St", Email = "charlie.davis@example.com", Phone = 5555678901, Active = false });
        //     customers.Add(new Customer { Id = 6, FirstName = "Emily", LastName = "Wilson", Address = "987 Birch Ave", Email = "emily.wilson@example.com", Phone = 5556789012, Active = true });
        //     customers.Add(new Customer { Id = 7, FirstName = "Frank", LastName = "Miller", Address = "159 Cedar St", Email = "frank.miller@example.com", Phone = 5557890123, Active = true });
        //     customers.Add(new Customer { Id = 8, FirstName = "Grace", LastName = "Lee", Address = "753 Spruce St", Email = "grace.lee@example.com", Phone = 5558901234, Active = false });
        //     customers.Add(new Customer { Id = 9, FirstName = "Henry", LastName = "Clark", Address = "852 Willow St", Email = "henry.clark@example.com", Phone = 5559012345, Active = true });
        //     customers.Add(new Customer { Id = 10, FirstName = "Isabella", LastName = "White", Address = "456 Aspen St", Email = "isabella.white@example.com", Phone = 5550123456, Active = true });
        // }

        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}