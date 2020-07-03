using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Service
{
    public class CustomerService : ICustomerService
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { FullName = "Tereena", Password = "tereena", Email = "tereena@gmail.com", PhoneNumber = 705665748, Address = "Chittoor" },
            new Customer { FullName = "Terna", Password = "terna", Email = "terna@gmail.com", PhoneNumber = 705748, Address = "Chittoor" },
        };

        //public CustomerService()
        //{
        //    customers.Add(new Customer());

        //}
        public List<Customer> GetCustomer()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomerByName(string name)
        {
            return customers.Where(c => c.FullName == name).FirstOrDefault();
        }

        public Customer Login(string username, string password)
        {
            foreach (var user in customers)
            {
                if ((username == user.FullName) && (password == user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public Customer UpdateCustomer(string name, Customer customer)
        {
            Customer _customer = customers.Where(c => c.FullName == name).FirstOrDefault();
            _customer.FullName = customer.FullName;
            _customer.Password = customer.Password;
            _customer.Email = customer.Email;
            _customer.PhoneNumber = customer.PhoneNumber;
            _customer.Address = customer.Address;


            return _customer;
        }

        public void DeleteCustomer(string name)
        {
            customers.Remove(customers.FirstOrDefault(c => c.FullName == name));
        }
    }
}