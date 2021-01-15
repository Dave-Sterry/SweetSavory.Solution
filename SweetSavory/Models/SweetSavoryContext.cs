using Microsoft.EntityFrameworkCore;

namespace SweetSavory.Models
{
  public class SweetSavoryContext: DbContext
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }
    public SweetSavoryContext(DbContextOptions options) : base(options) { }
  }

}