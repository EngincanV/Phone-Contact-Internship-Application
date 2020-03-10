using Nuevo.Business.Abstract;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        private readonly IDepartmantDal _departmantDal;

        public DepartmanManager(IDepartmantDal departmantDal)
        {
            _departmantDal = departmantDal;
        }

        public Departmant GetById(int id)
        {
            return _departmantDal.GetById(id);
        }
    }
}
