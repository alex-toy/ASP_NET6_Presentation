using GestionCoursWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionCoursWeb.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Diplome> Diplomes { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Eleve> Eleves { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureDiplome(modelBuilder);
        ConfigurePromotion(modelBuilder);
        ConfigureEleve(modelBuilder);
    }

    private static void ConfigureDiplome(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Diplome>().HasKey(d => d.Id);

        modelBuilder.Entity<Diplome>().Property(d => d.Code).IsRequired().HasMaxLength(10);
        modelBuilder.Entity<Diplome>().HasIndex(u => u.Code).IsUnique();
        modelBuilder.Entity<Diplome>().Property(d => d.Nom).IsRequired().HasMaxLength(80);
        modelBuilder.Entity<Diplome>().Property(d => d.Niveau).IsRequired();
    }

    private static void ConfigurePromotion(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Promotion>().HasKey(d => d.Id);

        modelBuilder.Entity<Promotion>().Property(d => d.Nom).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Promotion>().Property(d => d.Debut).IsRequired();
        modelBuilder.Entity<Promotion>().Property(d => d.Fin).IsRequired();

        modelBuilder.Entity<Promotion>().HasOne<Diplome>(d => d.Diplome)
                                        .WithMany(d => d.Promotions)
                                        .OnDelete(DeleteBehavior.Cascade);
    }

    private static void ConfigureEleve(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Eleve>().HasKey(d => d.Id);

        modelBuilder.Entity<Eleve>().Property(d => d.Nom).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Eleve>().HasMany<Promotion>(d => d.Promotions)
                                    .WithMany(d => d.Eleves);
    }
}
