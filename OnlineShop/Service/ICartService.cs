using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Service
{
    public interface ICartService
    {
        List<Product> ViewCart();
        Product AddToCart(int id);
    }
}
