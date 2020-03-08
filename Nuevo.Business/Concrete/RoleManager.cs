using Nuevo.Business.Abstract;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public Role GetById(int id)
        {
            return _roleDal.GetById(id);
        }
    }
}
