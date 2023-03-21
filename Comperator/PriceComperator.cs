using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Comperator
{
    public class PriceComperator : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return (int)(x.Price - y.Price);
        }
    }
}
