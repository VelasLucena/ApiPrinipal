using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ApiRest.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating (builder);
        }

        public DbSet<UserModel> UserModel { get; set; }
    }
}
