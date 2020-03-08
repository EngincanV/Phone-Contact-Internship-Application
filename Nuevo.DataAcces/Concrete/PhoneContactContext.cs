using Microsoft.EntityFrameworkCore;
using Nuevo.Entities.Concrete;

namespace Nuevo.DataAccess.Concrete
{
    public class PhoneContactContext : DbContext
    {
        public PhoneContactContext(DbContextOptions<PhoneContactContext> options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
