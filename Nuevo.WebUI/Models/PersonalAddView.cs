using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nuevo.WebUI.Models
{
    public class PersonalAddView
    {
        public List<SelectListItem> Departmant { get; set; }
        public List<SelectListItem> Manager { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Surname { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }
        
        public int DepartmantId { get; set; }
        public int ManagerId { get; set; }
    }
}
