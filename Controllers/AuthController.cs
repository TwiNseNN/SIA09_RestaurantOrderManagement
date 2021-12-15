using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    public class AuthController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        protected Services.AuthService _authService;

        public AuthController(
            Data.RestaurantManagementOrderContext context,
            Services.AuthService authService
        )
        {
            _context = context;
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(
            [FromQuery(Name = "RedirectTo")] string redirectTo,
            Models.Auth.Login loginModel)
        {

            try
            {
                var user = _authService.ValidateCredentials(loginModel);
                var claims = new List<Claim>()
                {
                    new Claim("type", Enum.GetName(typeof(UserType), user.Type)),
                    new Claim("email", user.Email),
                    new Claim("name", user.Name),
                    new Claim("userId", user.UserId.ToString())
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));
                return Redirect(redirectTo ?? "/");
            }
            catch (Services.EmailPasswordIncorrect)
            {
                ViewData["error"] = "The username or password is incorrect.";
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
