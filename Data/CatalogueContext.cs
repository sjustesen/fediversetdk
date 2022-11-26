using Microsoft.EntityFrameworkCore;
using Fediverset.Models;

namespace Fediverset.Data;

  public class CatalogueContext : DbContext
  {
    public DbSet<Category>? Category { get; set; }

    public DbSet<Link>? Link { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseMySQL("server=localhost;database=fediverset;user=user;password=verysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Category>(entity =>
      {
        entity.HasKey(e => e.CategoryId);
        entity.Property(e => e.Name).IsRequired();
      });

      modelBuilder.Entity<Link>(entity =>
      {
        entity.HasKey(e => e.LinkId);
        entity.Property(e => e.Name).IsRequired();
        entity.HasOne(d => d.Category)
          .WithMany(p => p.Links);
      });
    }
  }