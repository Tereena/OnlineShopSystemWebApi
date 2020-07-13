
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
        IEmployeeService _employeeService;
        public AuthenticateController(ICustomerService customerService, IEmployeeService employeeService)
        {
            _customerService = customerService;
            _employeeService = employeeService;
        }
        public Customer login([FromBody]CustomerAuthentication data)
        {
            Customer _customer = _customerService.Login(data.UserName, data.PassWord);
            return _customer;
        }
        //[HttpPost]
        //public Employee Authenticate([FromBody] CustomerAuthentication data)
        //{
        //    Employee _employee = _employeeService.Login(data.UserName, data.PassWord);
        //    return _employee;
        //}
    }
}
