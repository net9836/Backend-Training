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
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Products>> GetProducts()
        {
            return  _productRepository.GetAll();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Products> GetProducts(int id )
        {
            var products = _productRepository.GetsByID(id);
            
            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutProducts(int id, Products products)
        {
            if (id != products.ProductId)
            {
                return BadRequest();
            }

            try
            {
                _productRepository.Update(products);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_productRepository.ProductsExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Products> PostProducts(Products products)
        {
            _productRepository.Add(products);
            
            return CreatedAtAction("GetProducts", new { id = products.ProductId }, products);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProducts(int id)
        {
            _productRepository.DeleteByID(id);
            return Ok();
        }
    }
}
