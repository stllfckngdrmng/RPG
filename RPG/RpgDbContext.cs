using System;
using Microsoft.EntityFrameworkCore;

namespace RPG
{
    public class RpgDbContext: DbContext, IDisposable
    {
        public DbSet<Skill> Skills { get; set; }
    
        public RpgDbContext()
        {
            Database.EnsureCreated();
        }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=RPG-Test;User Id=postgres;Password=12345");
        }
    }
}