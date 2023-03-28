using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllOrder();
        void AddOrder(Order order);
        
    }
}
