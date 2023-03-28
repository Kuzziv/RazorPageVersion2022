using RazorPageVersion2022.Comperator;
using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.JsonService;
using RazorPageVersion2022.Service.SQLService;

namespace RazorPageVersion2022.Service.MockDataService
{
    public class MockItemService : IItemService
    {
        private JsonFileService<Item> _jsonFileService;
        private DbServiceGeneric<Item> _dbServiceGeneric;

        private List<Item> _items;

        public MockItemService(JsonFileService<Item> jsonFileService, DbServiceGeneric<Item> dbServiceGeneric)
        {            
            _jsonFileService = jsonFileService;
            _dbServiceGeneric = dbServiceGeneric;
            //_items = MockData.MockItems.GetAllItems();
            //_items = _jsonFileService.GetJsonObjects().ToList();
            _items = _dbServiceGeneric.GetObjectsAsync().Result.ToList();
        }
        public List<Item> GetAllItems()
        {
            return _items.ToList();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
            _jsonFileService.SaveJsonObjects(_items);
            _dbServiceGeneric.AddObjectAsync(item);
        }

        public Item DeleteItem(int? itemId)
        {
            Item itemToBeDeleted = null;
            foreach (Item item in _items)
            {
                if (item.Id == itemId)
                {
                    itemToBeDeleted = item;
                    break;
                }
            }
            if (itemToBeDeleted != null)
            {
                _items.Remove(itemToBeDeleted);
                _jsonFileService.SaveJsonObjects(_items);
                _dbServiceGeneric.DeleteObjectAsync(itemToBeDeleted);
            }
            return itemToBeDeleted;
        }
        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                foreach (Item i in _items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Name = item.Name;
                        i.Price = item.Price;
                    }
                }
                _jsonFileService.SaveJsonObjects(_items);
                _dbServiceGeneric.UpdateObjectAsync(item);
            }
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

        public IEnumerable<Item> SortById()
        {
            return from item in _items
                   orderby item.Id
                   select item;
        }


        public IEnumerable<Item> SortByIdDescending()
        {
            return from item in _items
                   orderby item.Id descending
                   select item;
        }


        public IEnumerable<Item> SortByName()
        {            
            return from items in _items
                   orderby items.Name
                   select items;
        }

        public IEnumerable<Item> SortByNameDescending()
        {
            return from items in _items
                   orderby items.Name descending
                   select items;
        }

        public IEnumerable<Item> SortByPrice()
        {
            return from items in _items
                   orderby items.Price
                   select items;
        }

        public IEnumerable<Item> SortByPriceDescending()
        {
            return from items in _items
                   orderby items.Price descending
                   select items;
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

    }
}
