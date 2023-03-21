using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.Comperator
{
    public class NameComperator : IComparer<Item>
    {

        public int Compare(Item x, Item y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
