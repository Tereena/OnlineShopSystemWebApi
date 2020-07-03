
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
    public class AuthenticateController : ApiController
    {
        ICustomerService _customerService;

        public AuthenticateController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public Customer login([FromBody]CustomerAuthentication data)
        {
            Customer _customer = _customerService.Login(data.UserName, data.PassWord);
            return _customer;
        }
    }
}
