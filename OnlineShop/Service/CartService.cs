using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Service
{
    public class CartService : ICartService
    {
        List<Cart> cartItems = new List<Cart>();
        IProductService _productService;
        public CartService(IProductService productService)
        {
            _productService = productService;
        }
        //int j = 0;
        //public Product AddToCart(Guid id,int productid)
        //{
        //    for (var i = 0; i < ProductService.products.Count; i++)
        //    {
        //        if (ProductService.products[i].ProductId == id)
        //        {
        //            var a = ProductService.products[i];
        //            cartItems.Add(a);
        //            return cartItems[j++];
        //        }
        //    }
        //    return null;
        //}
        public void AddToCart(Guid id, int productid)
        {

            foreach (var item in _productService.GetProduct())
            {
                if (item.ProductId == productid)
                {
                    cartItems.Add(new Cart() { ProductId = item.ProductId, ProductName = item.ProductName, ProductCost = item.ProductCost, CustomerCartId = id });

                    
                }
            }
            
        }
        //public void AddTo(int id)
        //{
        //    List<Item> cart = new List<Item>();
        //    cart.Add(new Item { Product = ProductService.products.Find(id)});
        //}
        public List<Cart> ViewCart(Guid id)
        {
            foreach (var item in cartItems)
            {
                if (id == item.CustomerCartId)
                {
                    return cartItems;
                }

            }
            return null;
        }

        public void DeleteCart(Guid id,int productid)
        {
            //cartItems.Remove(cartItems.FirstOrDefault(c => c.ProductId == id));
            foreach (var item in cartItems)
            {
                if (item.ProductId == productid && item.CustomerCartId == id)
                {

                    cartItems.Remove(item);
                    
                }

            }
            
        }
    }
}