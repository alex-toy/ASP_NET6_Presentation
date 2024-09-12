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
}
