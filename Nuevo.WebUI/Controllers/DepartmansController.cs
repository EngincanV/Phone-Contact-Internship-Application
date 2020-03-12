using System;
using Microsoft.AspNetCore.Mvc;
using Nuevo.Business.Abstract;
using Nuevo.Entities.Concrete;
using Nuevo.WebUI.Models;

namespace Nuevo.WebUI.Controllers
{
    public class DepartmansController : Controller
    {
        private readonly IDepartmantService _departmantService;
        private readonly IPersonalService _personalService;

        public DepartmansController(IDepartmantService departmantService, IPersonalService personalService)
        {
            _departmantService = departmantService;
            _personalService = personalService;
        }


        [HttpGet("{controller}/")]
        public IActionResult Index()
        {
            var departmants = _departmantService.GetAll();
            var departmantView = new DepartmentView
            {
                Departmants = departmants
            };

            return View(departmantView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDepartmant([Bind("Name")] Departmant departmant)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _departmantService.Add(departmant);

                    return RedirectToAction("Index", "Departmans");
                }
                catch (Exception e)
                {
                    throw;
                }
            }

            return RedirectToAction("Index", "Departmans");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var department = _departmantService.GetById((int)id);
            var departmentCount = _personalService.GetAllByDepartmentId((int)id).Count;

            if (department == null)
                return NotFound();

            if(departmentCount >= 1)
                _departmantService.Delete((int)id);

            return RedirectToAction("Index", "Departmans");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind("Id, Name")] Departmant departmant)
        {
            if (id == null || id != departmant.Id)
                return NotFound();

            _departmantService.Update(departmant);
            
            return RedirectToAction("Index", "Departmans");
        }
    }
}