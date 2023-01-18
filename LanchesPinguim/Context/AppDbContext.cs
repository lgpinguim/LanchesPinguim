using LanchesPinguim.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesPinguim.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Snack> Snacks { get; set; }

    }
}
