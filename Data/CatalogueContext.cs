namespace Fediverset.Data;

using Microsoft.EntityFrameworkCore;
using Fediverset.Models;

public partial class CatalogueContext : DbContext
{
    public DbSet<Category>? Category { get; set; }
    public DbSet<Link>? Link { get; set; }

    protected readonly IConfiguration Configuration;
    public CatalogueContext(IConfiguration configuration)
    {
        this.Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySQL(this.Configuration.GetConnectionString("DefaultConnection"));
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