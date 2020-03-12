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

        public User GetUserByUsername(string username)
        {
            return _userDal.GetUserByUsername(username);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public User GetUserId(int id)
        {
            return _userDal.GetById(id);
        }
    }
}
