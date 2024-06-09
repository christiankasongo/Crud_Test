using System.ComponentModel.DataAnnotations;

namespace Crud.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string FullName
        {
            get { return string.Concat(FirstName, " ", LastName); }
        }
        [Required] public string Address { get; set; }
        [Required][DataType(DataType.EmailAddress)][EmailAddress] public string Email { get; set; }
        public int Phone { get; set; }

        public bool Active { get; set; } = true;

    }
}