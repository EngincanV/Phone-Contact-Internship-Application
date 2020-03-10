using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        User IsUserExist(string username, string password);
        User GetUserByUsername(string username);
    }
}
