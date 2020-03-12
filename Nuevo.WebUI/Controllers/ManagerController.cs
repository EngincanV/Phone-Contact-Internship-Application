using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nuevo.Business.Abstract;
using Nuevo.Entities.Concrete;
using Nuevo.WebUI.Models;

namespace Nuevo.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManagerController : Controller
    {
        private readonly IUserService _userService;
        private readonly IManagerService _managerService;
        private readonly IDepartmantService _departmantService;
        private readonly IPersonalService _personalService;

        public ManagerController(IUserService userService, IManagerService managerService, IDepartmantService departmantService, IPersonalService personalService)
        {
            _userService = userService;
            _managerService = managerService;
            _departmantService = departmantService;
            _personalService = personalService;
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

        [HttpGet("{controller}/add-personal")]
        public IActionResult AddPersonal()
        {
            List<SelectListItem> departmantItems = new List<SelectListItem>();
            var departmants = _departmantService.GetAll();

            List<SelectListItem> managerItems = new List<SelectListItem>();
            var managers = _managerService.GetAll();

            foreach (var departmant in departmants)
            {
                departmantItems.Add(new SelectListItem { Text = departmant.Name, Value = departmant.Id.ToString() });
            }

            foreach (var manager in managers)
            {
                managerItems.Add(new SelectListItem { Text = manager.Name + " " + manager.Surname, Value = manager.Id.ToString() });
            }

            PersonalAddView personalAddView = new PersonalAddView
            {
                Departmant = departmantItems,
                Manager = managerItems
            };

            return View(personalAddView);
        }

        [HttpPost("{controller}/add-personal")]
        public IActionResult AddPersonal([Bind("Name, Surname, PhoneNumber, DepartmantId, ManagerId")] PersonalAddView personal)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Personal newPersonal = new Personal
                    {
                        DepartmantId = Convert.ToInt32(personal.DepartmantId),
                        ManagerId = Convert.ToInt32(personal.ManagerId),
                        Name = personal.Name,
                        Surname = personal.Surname,
                        PhoneNumber = personal.PhoneNumber
                    };
                    _personalService.Add(newPersonal);
                    return RedirectToAction("Index", "Home");
                }
                catch
                {
                    ViewBag.error = "Personal could not added";
                    return RedirectToAction("AddPersonal");
                }
            }

            ViewBag.error = "Please fill the blank fields correctly.";
            return RedirectToAction("AddPersonal");
        }

        [HttpPost("{controller}/delete-personal")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePersonal(int? id)
        {
            if (id == null)
                return BadRequest();

            var personal = _personalService.GetById((int)id);

            if (personal == null)
                return NotFound();

            _personalService.Delete((int)id);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("{controller}/edit-personal")]
        public IActionResult EditPersonal(int id, [Bind("Id, Name, Surname, PhoneNumber, DepartmantId, ManagerId")]Personal personal)
        {
            if (id != personal.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _personalService.Update(personal);
                    return RedirectToAction("Index", "Home");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_personalService.GetById(id) == null)
                        return NotFound();

                    else
                        throw;
                }
            }

            return RedirectToAction("EditPersonal", "Manager", id);
        }
    }
}