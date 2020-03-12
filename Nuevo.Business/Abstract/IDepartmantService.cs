using System.Collections.Generic;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Abstract
{
    public interface IDepartmantService
    {
        Departmant GetById(int id);
        IList<Departmant> GetAll();
        void Add(Departmant departmant);
        void Delete(int id);
        void Update(Departmant departmant);
    }
}
