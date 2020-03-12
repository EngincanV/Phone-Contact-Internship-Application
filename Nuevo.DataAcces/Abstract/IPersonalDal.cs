using System.Collections.Generic;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Abstract
{
    public interface IPersonalDal : IEntityRepository<Personal>
    {
        List<Personal> GetAllByDepartmentId(int departmentId);
    }
}
