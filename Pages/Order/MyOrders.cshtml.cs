using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.DAO;
using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Order
{
    public class MyOrdersModel : PageModel
    {
        private IUserService _iuserService;

        public IEnumerable<OrderDAO> MyOrders{ get; set; }        

        public MyOrdersModel(IUserService userService)
        {
            _iuserService = userService;
        }

        public IActionResult OnGet()
        {            
            User CurrentUser = _iuserService.GetUserByUserName(HttpContext.User.Identity.Name);
            MyOrders = _iuserService.GetUserOrders(CurrentUser);
            
            return Page();
        }
    }
}
