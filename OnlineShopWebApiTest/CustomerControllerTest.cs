//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using OnlineShop.Controllers;
//using OnlineShop.Models;
//using OnlineShop.Service;
//using System;
//using System.Collections.Generic;
//using Xunit;

//namespace OnlineShopWebApiTest
//{
//    public class CustomerControllerTest
//    {
//        private readonly Mock<ICustomerService> _mockCustomer;
//        private CustomerController _controller;

//        public CustomerControllerTest()
//        {
//            _mockCustomer = new Mock<ICustomerService>();
//            _controller = new CustomerController(_mockCustomer.Object);
//        }
//        [Fact]
//        public void Test1()
//        {
//            //Act
//            _mockCustomer.Setup(customer => customer.GetCustomer()).Returns(new List<Customer>());
//            var result = _controller.Get();
//            //asert
//            Assert.IsType<OkObjectResult>(result);

//        }
//    }
//}
