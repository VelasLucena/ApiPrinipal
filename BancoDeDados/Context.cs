using Microsoft.EntityFrameworkCore;
using User;

namespace DataBase
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserClient> UserAluno { get; set; }
    }
}