using System.Linq;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class UserDal : EntityRepositoryBase<User>, IUserDal
    {
        private readonly PhoneContactContext _context;

        public UserDal(PhoneContactContext context):base(context)
        {
            _context = context;
        }

        public User IsUserExist(string username, string password)
        {
            var isUserExist =
                _context.Users.FirstOrDefault(p => p.Username.Equals(username) && p.Password.Equals(password));
            return isUserExist;
        }
    }
}
