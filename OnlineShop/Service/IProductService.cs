using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Service
{
    public interface IProductService
    {
        List<Product> GetProduct();
        Product GetProductById(int id);
        void AddProduct(Product product);
        Product UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
    }
}
