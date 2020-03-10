using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class PersonalDal : EntityRepositoryBase<Personal>, IPersonalDal
    {
        public PersonalDal(PhoneContactContext context) : base(context) { }
    }
}
