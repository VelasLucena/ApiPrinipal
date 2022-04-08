using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}