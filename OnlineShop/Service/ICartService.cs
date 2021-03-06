﻿using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Service
{
    public interface ICartService
    {
        List<Cart> ViewCart(Guid id);
        void AddToCart(Guid id, int productid);
        void DeleteCart(Guid id,int productid);
    }
}
