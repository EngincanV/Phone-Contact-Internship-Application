using System.Collections.Generic;
using System.Linq;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class PersonalDal : EntityRepositoryBase<Personal>, IPersonalDal
    {
        private readonly PhoneContactContext _context;

        public PersonalDal(PhoneContactContext context) : base(context)
        {
            _context = context;
        }
        public List<Personal> GetAllByDepartmentId(int departmentId)
        {
            return _context.Personels.Where(p => p.DepartmantId.Equals(departmentId)).ToList();
        }
    }
}
