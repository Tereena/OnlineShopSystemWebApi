using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Service
{
    public class CartService : ICartService
    {
        List<Product> cartItems = new List<Product>();
        int j = 0;
        public Product AddToCart(int id)
        {
            for (var i = 0; i < ProductService.products.Count; i++)
            {
                if (ProductService.products[i].ProductId == id)
                {
                    var a = ProductService.products[i];
                    cartItems.Add(a);
                    return cartItems[j++];
                }
            }
            return null;
        }

        public List<Product> ViewCart()
        {
            return cartItems;
        }
    }
}