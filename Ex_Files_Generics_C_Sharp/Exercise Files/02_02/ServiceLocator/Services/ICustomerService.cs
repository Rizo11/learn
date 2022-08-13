using System;
namespace Example.Services
{
    public interface ICustomerService : IService
    {
        object GetCurrent();
        object CreateOrder(object customer);
    }

    public class CustomerService : ICustomerService
    {
        public object CreateOrder(object customer)
        {
            throw new NotImplementedException();
        }

        public object GetCurrent()
        {
            throw new NotImplementedException();
        }
    }
}
