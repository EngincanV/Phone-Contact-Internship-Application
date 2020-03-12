using Microsoft.AspNetCore.Mvc.Rendering;
using Nuevo.Entities.Concrete;
using System.Collections.Generic;

namespace Nuevo.WebUI.Models
{
    public class PersonalDetailView
    {
        public Personal Personal { get; set; }
        public Departmant Departmant { get; set; }
        public Manager Manager { get; set; }
        public bool isDisabled { get; set; }

        public List<SelectListItem> Departmants { get; set; }
        public List<SelectListItem> Managers { get; set; }
    }
}
