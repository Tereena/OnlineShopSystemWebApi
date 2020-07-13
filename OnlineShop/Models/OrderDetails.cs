using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class OrderDetails
    {
        public int ProductID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public List<OrderDetails> Details { get; set; }
    }
}