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

        public Item GetItemById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
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

        public IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Item> filterList = new List<Item>();
            foreach (Item item in _items)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }
            return filterList;
        }

        public void UpdateItem(Item item)
        {
            if (_items != null)
            {
                foreach (Item i in _items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Name = item.Name;
                        i.Price = item.Price;
                    }
                }
            }
        }


    }
}
