using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly NORTHWNDContext _context;
        
        public ProductRepository(NORTHWNDContext context)
        {
            _context = context;
        }
        public void Add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteByID(int id)
        {
            var products = _context.Products.Find(id);

            _context.Products.Remove(products);
            _context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Products GetName(string name)
        {
            return _context.Products.Find(name);
        }

        public Products GetsByID(int id)
        {
            return _context.Products.Find(id);
        }

        public bool ProductsExists(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChangesAsync();
            
        }
    }
}
