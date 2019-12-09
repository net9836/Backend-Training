using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;

namespace Repository
{
    public interface IProductRepository
    {
        Products GetsByID(int id);
        Products GetName(string name);
        List<Products> GetAll();
        void DeleteByID(int id);
        void Update(Products product);
        void Add(Products product);
        bool ProductsExists(int id);
    }
}
