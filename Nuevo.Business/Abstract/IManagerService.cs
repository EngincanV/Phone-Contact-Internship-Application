using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Abstract
{
    public interface IManagerService
    {
        Manager GetById(int id);
    }
}
