using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;

namespace RazorPageVersion2022.Pages.Login
{
    public class CreateLoginModel : PageModel
    {
        private IUserService _iuserService;

        [BindProperty]
        public Models.User User { get; set; }


        public CreateLoginModel(IUserService userService)
        {
            _iuserService = userService;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _iuserService.AddUser(User);
            return RedirectToPage("/Login/LoginPage");
        }
    }
}
