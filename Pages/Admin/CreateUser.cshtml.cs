using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Service.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RazorPageVersion2022.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class CreateUserModel : PageModel
    {
        private IUserService _iuserService;

        private PasswordHasher<string> passwordHasher;

        [BindProperty] public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }


        public CreateUserModel(IUserService userService)
        {
            _iuserService = userService;
            passwordHasher = new PasswordHasher<string>();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _iuserService.AddUser(new Models.User(UserName, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Login/LoginPage");
        }
    }
}
