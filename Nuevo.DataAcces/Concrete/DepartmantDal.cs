using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class DepartmantDal : EntityRepositoryBase<Departmant>, IDepartmantDal
    {
        public DepartmantDal(PhoneContactContext context) : base(context) 
        {

        }
    }
}
