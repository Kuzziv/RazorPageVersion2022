using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Order
{
    public class OrderItemModel : PageModel
    {
        private IItemService _iItemService;
        private IUserService _iuserService;
        private IOrderService _iorderService;

        public Models.User User { get; set; }
        public Models.Item Item { get; set; }
        public Models.Order Order { get; set; } = new Models.Order();

        [BindProperty]
        public int Count { get; set; }
        //virtual ICollection<Order>;

        public OrderItemModel(IItemService itemService, IUserService userService, IOrderService orderService)
        {
            _iItemService = itemService;
            _iuserService = userService;
            _iorderService = orderService;
        }

        public void OnGet(int id)
        {
            Item = _iItemService.GetItemById(id);
            User = _iuserService.GetUserByUserName(HttpContext.User.Identity.Name); 
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Item = _iItemService.GetItemById(id);
            User = _iuserService.GetUserByUserName(HttpContext.User.Identity.Name);
            Order.UserId = User.UserId;
            Order.ItemId = Item.Id;
            Order.dateTime = DateTime.Now;
            Order.Count = Count;
            _iorderService.AddOrder(Order);
            return RedirectToPage("../Item/GetAllItems");
        }
    }
}
