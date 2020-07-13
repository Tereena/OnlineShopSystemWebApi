using Microsoft.AspNetCore.Mvc;
using Moq;
using OnlineShop.Controllers;
using OnlineShop.Models;
using OnlineShop.Service;
using System;
using System.Collections.Generic;
using Xunit;

namespace OnlineShopWebApiTest
{
    public class CustomerControllerTest
    {
        private readonly Mock<ICustomerService> _mockCustomer;
        private CustomerController _controller;

        public CustomerControllerTest()
        {
            _mockCustomer = new Mock<ICustomerService>();
            _controller = new CustomerController(_mockCustomer.Object);
        }
        [Fact]
        public void GetCustomer_Returns_customersWithOkayStatusCode()
        {
            //Act
            _mockCustomer.Setup(customer => customer.GetCustomer()).Returns(new List<Customer>());
            var result = _controller.Get();
            //asert
            Assert.IsType<OkObjectResult>(result);

        }

        [Theory]
        [InlineData("Tereena")]
        [InlineData("Terna")]
        
        public void GetCustomerByName_Returns_CustomerDetailsWithOkayStatusCode(string name)
        {
            //Act  
            _mockCustomer.Setup(x => x.GetCustomerByName(name)).Returns(new Customer());
            var data = _controller.Get(name);
            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Theory]
        [InlineData("Nani")]
        [InlineData("Naga")]
        public void GetCustomerByName_Returns_NotFoundStatusCode(string name)
        {
            _mockCustomer.Setup(x => x.GetCustomerByName(name)).Returns(new Customer());
            //Act  
            var data = _controller.Get(name);
            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);

        }
    }
}
