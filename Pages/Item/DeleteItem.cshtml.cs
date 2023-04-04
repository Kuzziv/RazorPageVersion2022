using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Item
{
    public class DeleteItemModel : PageModel
    {
        private IItemService _iItemService;

        [BindProperty] public Models.Item Item { get; set; }

        public DeleteItemModel(IItemService itemService)
        {
            _iItemService = itemService;
        }

        public IActionResult OnGet(int id)
        {
            Item = _iItemService.GetItemById(id);
            if (Item == null)
            {
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Models.Item deletedItem = await _iItemService.DeleteItemAsync(Item.Id);
            if (deletedItem == null)
            {
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu
            }
                
            return RedirectToPage("/Admin/ItemsPage");
        }
    }
}
