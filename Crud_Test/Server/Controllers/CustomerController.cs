using Microsoft.AspNetCore.Mvc;
using Crud_Test.Shared.Model;
using Crud_Test.Server.Interfaces;

namespace Crud_Test.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Customer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public async Task<IActionResult> GetCustomers()
        {
            var lst = await _customerService.GetCustomers();
            if (lst.Any())
            {
                return Ok(lst);
            }

            return NotFound("Customers not found");
        }

        [HttpPost("AddNew")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Customer))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            var success = await _customerService.AddCustomer(customer);
            if (success.Id == 0)
            {
                return BadRequest($"Unable to Update{customer.Id}");
            }

            return Ok(success);
        }

        [HttpPatch("Update")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            var success = await _customerService.UpdateCustomer(customer);
            if (!success)
            {
                return BadRequest($"Unable to Update{customer.Id}");
            }

            return Ok(success);
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> DeleteCustomer(int Id)
        {
            var success = await _customerService.DeleteCustomer(Id);
            if (!success)
            {
                return BadRequest("Customer does not exist or has already been deleted");
            }

            return Ok(success);
        }
    }
}