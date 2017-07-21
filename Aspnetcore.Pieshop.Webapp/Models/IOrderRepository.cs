namespace Aspnetcore.Pieshop.Webapp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}