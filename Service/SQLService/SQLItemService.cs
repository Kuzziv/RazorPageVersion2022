using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Service.SQLService
{
    public class SQLItemService : IItemService
    {
        public void AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Item DeleteItem(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> NameSearch(string str)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
