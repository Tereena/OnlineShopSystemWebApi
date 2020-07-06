using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Service
{
    public class ProductService : IProductService
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { ProductId = 1, ProductName = "Samsung", ProductCost = 10000 },
            new Product { ProductId = 2, ProductName = "Nokia", ProductCost = 1000, },
        };


        public List<Product> GetProduct()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product GetProductById(int id)
        {
            return products.Where(c => c.ProductId == id).FirstOrDefault();
        }

        public Product UpdateProduct(int id, Product product)
        {
            Product _product = products.Where(c => c.ProductId == id).FirstOrDefault();
            _product.ProductId = product.ProductId;
            _product.ProductName = product.ProductName;
            _product.ProductCost = product.ProductCost;



            return _product;
        }
        public void DeleteProduct(int id)
        {
            products.Remove(products.FirstOrDefault(c => c.ProductId == id));
        }
    }
}