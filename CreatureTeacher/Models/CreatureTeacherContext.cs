using Microsoft.EntityFrameworkCore;

namespace CreatureTeacher.Models
{
  public class CreatureTeacherContext : DbContext
  {
    public DbSet<Creature> Creatures {get; set;}
    public DbSet<Eye> Eyes {get;set;}
    public DbSet<Head> Heads {get;set;}
    public DbSet<Mouth> Mouths {get;set;}
    public DbSet<Tail> Tails {get;set;}

    public CreatureTeacherContext(DbContextOptions options) : base(options) {}
  }
}