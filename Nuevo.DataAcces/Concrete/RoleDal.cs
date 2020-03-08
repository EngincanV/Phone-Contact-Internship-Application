using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class RoleDal : IRoleDal
    {
        private readonly PhoneContactContext _context;

        public RoleDal(PhoneContactContext context)
        {
            _context = context;
        }

        public IList<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        public void Add(Role entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Role entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Roles.Find(id);
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
