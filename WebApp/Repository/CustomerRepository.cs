using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly NORTHWNDContext _context;

        public CustomerRepository(NORTHWNDContext context)
        {
            _context = context;
        }
        public void Add(Customers customer)

        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteByID(string id)
        {
            var customers = _context.Customers.Find(id);

            _context.Customers.Remove(customers);
            _context.SaveChanges();
        }

        public List<Customers> GetAll()
        {
            try
            {
                return _context.Customers.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Customers GetName(string name)
        {
            return _context.Customers.Find(name);
        }

        public Customers GetsByID(string id)
        {
            return _context.Customers.Find(id);
        }

        public bool CustomersExists(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customers customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
    }
}
