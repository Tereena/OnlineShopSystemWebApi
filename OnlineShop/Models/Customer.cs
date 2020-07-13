using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Customer
    {
        //private Guid customerUniqueId = new Guid();
        private Guid customerUniqueId = Guid.NewGuid();
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public Guid CustomerUniqueId { get => customerUniqueId; }
    }
}