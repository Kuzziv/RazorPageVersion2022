using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();

        Task AddItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Item GetItemById(int id);
        Task<Item> DeleteItemAsync(int? itemId);

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
