using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class ManagerDal : EntityRepositoryBase<Manager>, IManagerDal
    {
        public ManagerDal(PhoneContactContext context) : base(context)
        {
        }

    }
}
