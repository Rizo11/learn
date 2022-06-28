using System;
namespace Example.Services
{
    public interface IOrderService : IService
    {
        void Save(object order);
    }

    public class OrderService : IOrderService
    {
        public void Save(object order)
        {
            throw new NotImplementedException();
        }
    }
}
