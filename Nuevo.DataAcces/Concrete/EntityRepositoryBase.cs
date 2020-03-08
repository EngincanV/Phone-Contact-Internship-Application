using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Abstract;

namespace Nuevo.DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly PhoneContactContext _context;

        public EntityRepositoryBase(PhoneContactContext context)
        {
            _context = context;
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            var findEntity = _context.Set<TEntity>().Find(id);
            return findEntity;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var findEntity = _context.Set<TEntity>().Find(id);
            var deletedEntity = _context.Entry(findEntity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
