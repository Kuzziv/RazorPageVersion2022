using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();

        void AddItem(Item item);
        void UpdateItem(Item item);
        Item GetItemById(int id);

        IEnumerable<Item> NameSearch(string str);

        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);

    }
}
