using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nuevo.DataAccess.Abstract;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class UserDal : IUserDal
    {
        private readonly PhoneContactContext _context;

        public UserDal(PhoneContactContext context)
        {
            _context = context;
        }

        public IList<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Add(User entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(User entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Users.Find(id);
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public User IsUserExist(string username, string password)
        {
            var isUserExist =
                _context.Users.FirstOrDefault(p => p.Username.Equals(username) && p.Password.Equals(password));
            return isUserExist;
        }
    }
}
