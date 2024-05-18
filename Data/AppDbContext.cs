using dotnetblog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

namespace dotnetblog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "CloudComputing", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Programming", DisplayOrder = 2 },
                  new Category { Id = 3, Name = "DevOps", DisplayOrder = 3 });

        }

    }
}
