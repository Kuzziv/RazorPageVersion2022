using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.MockData
{
    public class MockItems
    {
        public static List<Item> itemsList = new List<Item>()
        {
            new Models.Item("PC", 5999),
            new Models.Item("Skærm", 1999),
            new Models.Item("Tastatur", 999)
        };

        public static List<Item> GetAllItems()
        {
            return itemsList;
        }

        public static void AddItem(Item item)
        {
            itemsList.Add(item);
        }
    }
}
