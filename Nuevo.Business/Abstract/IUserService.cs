using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Abstract
{
    public interface IUserService
    {
        User IsUserExist(string username, string password);
        User GetUserByUsername(string username);
        void Update(User user);
        User GetUserId(int id);
    }
}
