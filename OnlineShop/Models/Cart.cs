using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Cart
    {
        private int productId;
        private string productName;
        private double productCost;
        private Guid customerCartId;


        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double ProductCost { get => productCost; set => productCost = value; }
        public Guid CustomerCartId { get => customerCartId; set => customerCartId = value; }
    }
}