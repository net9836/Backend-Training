using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Models;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customers
        [HttpGet]
        public ActionResult<IEnumerable<Customers>> GetCustomers()
        {
            return _customerRepository.GetAll();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public ActionResult<Customers> GetCustomers(string id)
        {
            var customers = _customerRepository.GetsByID(id);

            if (customers == null)
            {
                return NotFound();
            }

            return customers;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutCustomers(string id, Customers customers)
        {
            if (id != customers.CustomerId)
            {
                return BadRequest();
            }

            try
            {
                _customerRepository.Update(customers);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_customerRepository.CustomersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Customers> PostCustomers(Customers customers)
        {
            _customerRepository.Add(customers);
           
            return CreatedAtAction("GetCustomers", new { id = customers.CustomerId }, customers);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomers(string id)
        {
            _customerRepository.DeleteByID(id);
            return Ok();
        }
    }
}
