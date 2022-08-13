using System;
using Example.Services;

namespace Example
{
    public class Program {
        public void Run(ServiceLocator serviceLocator){
            var orderService = (IOrderService)serviceLocator.CreateService("orders");
            var customerService = (ICustomerService)serviceLocator.CreateService("customers");

            var customer = customerService.GetCurrent();
            var order = customerService.CreateOrder(customer);
            orderService.Save(order);
        }

        public ServiceLocator Config()
        {
            var serviceLocator = new ServiceLocator();
            serviceLocator.AddService("orders", typeof(OrderService));
            serviceLocator.AddService("customers", typeof(CustomerService));
            return serviceLocator;
        }
    }
}
