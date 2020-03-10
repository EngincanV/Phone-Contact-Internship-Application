using Nuevo.Entities.Concrete;
using System.Collections.Generic;

namespace Nuevo.Business.Abstract
{
    public interface IPersonalService
    {
        IList<Personal> GetAll();
    }
}
