using Microsoft.EntityFrameworkCore;
using BlogApp.Domain.Entities;

namespace BlogApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

       public DbSet<User> Users { get; set; }
       public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurações adicionais de entidades
        }
    }
}
