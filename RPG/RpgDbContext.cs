using System;
using Microsoft.EntityFrameworkCore;

namespace RPG
{
    public class RpgDbContext: DbContext, IDisposable
    {
        public DbSet<Skill> Skills { get; set; }
    
        public RpgDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=RPG-Test;User Id=postgres;Password=dreamer1830");
            //base.OnConfiguring(optionsBuilder); // Пробовал это в для того чтобы исправить ексепшены, не знаю помогает или нет.
        }
    }
}