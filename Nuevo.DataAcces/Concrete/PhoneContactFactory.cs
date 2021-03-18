using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Nuevo.DataAccess.Concrete
{
    public class PhoneContactFactory : IDesignTimeDbContextFactory<PhoneContactContext>
    {
        public PhoneContactContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PhoneContactContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=PhoneContact;Trusted_Connection=true");

            return new PhoneContactContext(optionsBuilder.Options);
        }
    }
}