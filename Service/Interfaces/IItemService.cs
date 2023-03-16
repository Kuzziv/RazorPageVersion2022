using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Service.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();

        void AddItem(Item item);

        IEnumerable<Item> NameSearch(string str);

    }
}
