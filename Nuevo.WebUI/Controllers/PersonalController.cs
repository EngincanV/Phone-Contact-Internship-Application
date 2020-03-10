using Microsoft.AspNetCore.Mvc;
using Nuevo.Business.Abstract;
using Nuevo.WebUI.Models;

namespace Nuevo.WebUI.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _personalService;
        private readonly IDepartmanService _departmantService;
        private readonly IManagerService _managerService;

        public PersonalController(IPersonalService personalService, IDepartmanService departmantService, IManagerService managerService)
        {
            _personalService = personalService;
            _departmantService = departmantService;
            _managerService = managerService;
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            var getUser = _personalService.GetById((int)id);

            if (getUser != null)
            {
                var departmantInfo = _departmantService.GetById(getUser.DepartmentId);
                var managerInfo = _managerService.GetById(getUser.ManagerId);

                var personalDetail = new PersonalDetailView
                {
                    Personal = getUser,
                    Departmant = departmantInfo,
                    Manager = managerInfo
                };

                return View(personalDetail);
            }

            ViewBag.userNotFound = "User is not exist";
            return View();
        }
    }
}