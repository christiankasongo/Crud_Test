namespace Crud_Test.Server.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public long? Phone { get; set; }

        public bool Active { get; set; } = true;
    }
}