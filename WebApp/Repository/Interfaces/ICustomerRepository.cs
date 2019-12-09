using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;

namespace Repository
{
    public interface ICustomerRepository
    {
        Customers GetsByID(string id);
        Customers GetName(string name);
        List<Customers> GetAll();
        void DeleteByID(string id);
        void Update(Customers customer);
        void Add(Customers customer);
        bool CustomersExists(string id);
    }
}
