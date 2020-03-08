using Nuevo.Business.Abstract;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User IsUserExist(string username, string password)
        {
            return _userDal.IsUserExist(username, password);
        }
    }
}
