using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using RazorPageVersion2022.Service.MockDataService;

namespace RazorPageVersion2022.Pages.Login
{
    public class LoginPageModel : PageModel
    {
        public static User LoggedInUser { get; set; } = null;

        private IUserService _iUserService;

        [BindProperty] public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }

        public LoginPageModel(IUserService userService)
        {
            _iUserService = userService;
        }

        public async Task<IActionResult> OnPost()
        {

            List<User> users = _iUserService.GetAllUsers();
            foreach (User user in users)
            {

                if (UserName == user.UserName && Password == user.Password)
                {

                    LoggedInUser = user;

                    var claims = new List<Claim> { new Claim(ClaimTypes.Name, UserName) };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/Item/GetAllItems");

                }

            }

            Message = "Invalid attempt";
            return Page();
        }



        public void OnGet()
        {
        }
    }
}
