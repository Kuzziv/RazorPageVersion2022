using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        public List<Models.Item> Items { get; private set; }
        public IItemService _iItemService { get; private set; }

        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public int MinPrice { get; set; }
        [BindProperty] public int MaxPrice { get; set; }

        public GetAllItemsModel(IItemService itemService)
        {
            _iItemService = itemService;
        }

        public void OnGet()
        {
            Items = _iItemService.GetAllItems();
        }

        public IActionResult OnPostNameSearch()
        {
            Items = _iItemService.NameSearch(SearchString).ToList();
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            Items = _iItemService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
