using OnlineShop.Service;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace OnlineShop
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();


            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<ICartService, CartService>();
            container.RegisterType<IEmployeeService, EmployeeService>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}