using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DeepSea
{
  public partial class DeepSeaContext : DbContext
  {
    public DeepSeaContext()
    {
    }

    public DeepSeaContext(DbContextOptions<DeepSeaContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseNpgsql("server=localhost;database=DeepSea");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
    }

    public DbSet<Creature> Creatures { get; set; }


  }
}
