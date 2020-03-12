using System.Collections.Generic;
using Nuevo.Entities.Concrete;

namespace Nuevo.WebUI.Models
{
    public class DepartmentView
    {
        public IList<Departmant> Departmants { get; set; }
        public Departmant Departmant { get; set; }
    }
}
