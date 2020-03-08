using Nuevo.Entities.Concrete;

namespace Nuevo.Business.Abstract
{
    public interface IRoleService
    {
        Role GetById(int id);
    }
}
