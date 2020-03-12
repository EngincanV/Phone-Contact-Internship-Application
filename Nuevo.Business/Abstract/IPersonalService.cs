using Nuevo.Entities.Concrete;
using System.Collections.Generic;

namespace Nuevo.Business.Abstract
{
    public interface IPersonalService
    {
        IList<Personal> GetAll();
        Personal GetById(int id);
        void Add(Personal personal);
        void Delete(int id);
        void Update(Personal personal);
        List<Personal> GetAllByDepartmentId(int departmentId);
    }
}
