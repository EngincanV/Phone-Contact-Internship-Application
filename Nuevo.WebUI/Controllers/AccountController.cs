using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Business.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public AccountController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username, Password")] User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.emptyFields = "Lütfen kullanıcı adı ve şifrenizi boş bırakmayınız.";
                return View();
            }

            if (ModelState.IsValid)
            {
                var isUserExist = _userService.IsUserExist(user.Username, user.Password);

                if (isUserExist != null)
                {
                    var userRole = _roleService.GetById(isUserExist.RoleId);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, isUserExist.Username),
                        new Claim(ClaimTypes.Role, userRole.Name)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToAction("Index", "Home");
                }
            }

            ViewBag.emptyFields = "Lütfen giriş bilgilerinizi kontrol ediniz.";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}