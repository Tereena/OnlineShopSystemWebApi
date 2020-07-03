
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
    public class CustomerController : ApiController
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/Customer
        public List<Customer> Get()
        {
            return _customerService.GetCustomer();
        }

        // GET: api/Customer/5
        public Customer Get(string id)
        {
            Customer _customer = _customerService.GetCustomerByName(id);
            return _customer;
        }

        // POST: api/Customer
        public void Post([FromBody]Customer customer)
        {
            _customerService.AddCustomer(customer);
        }

        // PUT: api/Customer/5
        public Customer Put(string Name, [FromBody]Customer customer)
        {
           return _customerService.UpdateCustomer(Name, customer);
        }

        // DELETE: api/Customer/5
        public void Delete(string id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
