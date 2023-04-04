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
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _iItemService.AddItemAsync(Item);
            return RedirectToPage("/Admin/ItemsPage");
        }
    }
}
