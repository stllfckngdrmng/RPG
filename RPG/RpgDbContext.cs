using Microsoft.EntityFrameworkCore;

namespace RPG;

public class RpgDbContext: DbContext
{
    public DbSet<Skill> Skills { get; set; }
    
    public RpgDbContext()
    {
        Database.EnsureCreated();
    }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=rpgappdb;Trusted_Connection=True;");
    }
}