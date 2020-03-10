using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Business.Abstract;
using Nuevo.WebUI.Models;

namespace Nuevo.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManagerController : Controller
    {
        private readonly IUserService _userService;

        public ManagerController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword([Bind("CurrentPassword, NewPasswordAgain, NewPassword")] ManagerPasswordView managerPasswordView)
        {
            var username = User.Identity.Name;
            var findUser = _userService.GetUserByUsername(username);

            if (ModelState.IsValid &&
                findUser.Password.Equals(managerPasswordView.CurrentPassword) &&
                managerPasswordView.NewPassword.Equals(managerPasswordView.NewPasswordAgain))
            {
                findUser.Password = managerPasswordView.NewPassword;
                _userService.Update(findUser);

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}