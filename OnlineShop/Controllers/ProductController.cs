
using OnlineShop.Models;
using OnlineShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShop.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/Customer
        public List<Product> Get() 
        {
            return _productService.GetProduct();
        }

        // GET: api/Customer/5
        public Product Get(int id)
        {
            Product _product = _productService.GetProductById(id);
            return _product;
        }

        // POST: api/Customer
        public void Post([FromBody]Product product)
        {
            _productService.AddProduct(product);
        }

        // PUT: api/Customer/5
        public Product Put(int id, [FromBody]Product product)
        {
            return _productService.UpdateProduct(id, product);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
