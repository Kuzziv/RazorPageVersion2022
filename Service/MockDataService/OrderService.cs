using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.JsonService;
using RazorPageVersion2022.Service.SQLService;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class OrderService
    {
        public DbServiceGeneric<Order> _DbGeneric;
        public JsonFileService<Order> _JsonFileService;
        public List<Order> _Orders;

        public OrderService(JsonFileService<Order> jsonFileService, DbServiceGeneric<Order> dbServiceGeneric)
        {
            _JsonFileService = jsonFileService;
            _DbGeneric = dbServiceGeneric;
            _Orders = _DbGeneric.GetObjectsAsync().Result.ToList();
        }


    }
}
