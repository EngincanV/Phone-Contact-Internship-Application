using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class RoleDal : EntityRepositoryBase<Role>, IRoleDal
    {
        private readonly PhoneContactContext _context;

        public RoleDal(PhoneContactContext context):base(context)
        {
            _context = context;
        }
    }
}
