using Nuevo.Entities.Abstract;
using System.Collections.Generic;

namespace Nuevo.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        IList<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
