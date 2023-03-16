using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Item
{
    public class CreateItemModel : PageModel
    {

        private IItemService _iItemService;

        [BindProperty]
        public Models.Item Item { get; set; }

        public CreateItemModel(IItemService itemService)
        {
            _iItemService = itemService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _iItemService.AddItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
