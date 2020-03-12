using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Nuevo.Business.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.WebUI.Helpers
{
    public class SelectDetails
    {
        public List<SelectListItem> GetDepartmantItems(Personal personal, IDepartmantService departmantService)
        {
            var departmantItems = new List<SelectListItem>();
            var departmants = departmantService.GetAll();

            foreach (var departmant in departmants)
            {
                departmantItems.Add(departmant.Id == personal.DepartmantId
                    ? new SelectListItem { Text = departmant.Name, Value = departmant.Id.ToString(), Selected = true }
                    : new SelectListItem { Text = departmant.Name, Value = departmant.Id.ToString() });
            }

            return departmantItems;
        }

        public List<SelectListItem> GetManagerItems(Personal personal, IManagerService managerService)
        {
            var managerItems = new List<SelectListItem>();
            var managers = managerService.GetAll();

            foreach (var manager in managers)
            {
                managerItems.Add(manager.Id == personal.ManagerId
                    ? new SelectListItem
                        { Text = manager.Name + " " + manager.Surname, Value = manager.Id.ToString(), Selected = true }
                    : new SelectListItem { Text = manager.Name + " " + manager.Surname, Value = manager.Id.ToString() });
            }

            return managerItems;
        }

    }
}
