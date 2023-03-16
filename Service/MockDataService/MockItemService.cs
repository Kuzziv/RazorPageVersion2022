using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class MockItemService : IItemService
    {
        private List<Item> _items;

        public MockItemService()
        {
            _items = MockData.MockItems.GetAllItems();
        }

        public void AddItem(Item item)
        {
            MockData.MockItems.AddItem(item);
        }

        public List<Item> GetAllItems()
        {
            return MockData.MockItems.GetAllItems();
        }

        public IEnumerable<Item> NameSearch(string str)
        {
            List<Item> nameSearchList = new List<Item>();
            foreach (Item item in _items)
            {
                if (item.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearchList.Add(item);
                }
            }
            return nameSearchList;
        }
    }
}
