using System.Collections.Generic;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Abstract
{
    public interface IDepartmantService
    {
        Departmant GetById(int id);
        IList<Departmant> GetAll();
    }
}
