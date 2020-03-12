using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nuevo.Business.Abstract;
using Nuevo.WebUI.Models;
using System.Collections.Generic;
using Nuevo.Entities.Concrete;
using Nuevo.WebUI.Helpers;

namespace Nuevo.WebUI.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _personalService;
        private readonly IDepartmantService _departmantService;
        private readonly IManagerService _managerService;
        private readonly IUserService _userService;

        public PersonalController(IPersonalService personalService, IDepartmantService departmantService, IManagerService managerService, IUserService userService)
        {
            _personalService = personalService;
            _departmantService = departmantService;
            _managerService = managerService;
            _userService = userService;
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            var helpers = new SelectDetails();

            var getUser = _personalService.GetById((int)id);
            var departmantItems = helpers.GetDepartmantItems(getUser, _departmantService);
            var managerItems = helpers.GetManagerItems(getUser, _managerService);
            var username = _userService.GetUserId(getUser.ManagerId).Username;

            if (getUser != null)
            {
                var departmantInfo = _departmantService.GetById(getUser.DepartmantId);
                var managerInfo = _managerService.GetById(getUser.ManagerId);

                var personalDetail = new PersonalDetailView
                {
                    Personal = getUser,
                    Departmant = departmantInfo,
                    Manager = managerInfo,
                    Departmants = departmantItems,
                    Managers = managerItems,
                    isDisabled = username == User.Identity.Name ? true : false
                };

                return View(personalDetail);
            }

            ViewBag.userNotFound = "User is not exist";
            return View();
        }
    }
}