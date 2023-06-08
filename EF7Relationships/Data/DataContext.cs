using EF7Relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace EF7Relationships.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        // by exposing this constructor, we can provide these options at the moment we register the DbContext on the pipeline.
    }
    
    public DbSet<Character> Characters { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    // to create many-to-many relationships, a JUNCTION table is created (see CharacterFaction db)
    public DbSet<Faction> Factions { get; set; }
}