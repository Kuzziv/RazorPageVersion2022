using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        public List<Models.Item> Items { get; private set; }
        public IItemService _iItemService { get; private set; }

        public GetAllItemsModel(IItemService itemService)
        {
            _iItemService = itemService;
        }

        public void OnGet()
        {
          Items = _iItemService.GetAllItems();
        }
    }
}
