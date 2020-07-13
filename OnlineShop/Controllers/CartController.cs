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
    public class CartController : ApiController
    {
        private ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        // GET: api/Cart
        public List<Cart> Get(Guid id)
        {
            return _cartService.ViewCart(id);
        }

        // GET: api/Cart/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Cart
        public void Add(Guid id,int productid)
        {
            _cartService.AddToCart(id,productid);
        }

        // PUT: api/Cart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cart/5
        public void Delete(Guid id,int productid)
        {
            _cartService.DeleteCart(id,productid);
        }
    }
}
