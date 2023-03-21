using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();

        void AddItem(Item item);
        void UpdateItem(Item item);
        Item GetItemById(int id);
        Item DeleteItem(int? id);

        IEnumerable<Item> SortById();
        IEnumerable<Item> SortByIdDescending();
        IEnumerable<Item> SortByName();
        IEnumerable<Item> SortByNameDescending();
        IEnumerable<Item> SortByPrice(); 
        IEnumerable<Item> SortByPriceDescending(); 
        IEnumerable<Item> NameSearch(string str);

        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);

    }
}
