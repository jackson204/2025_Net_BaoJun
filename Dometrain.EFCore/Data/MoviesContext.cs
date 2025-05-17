using Dometrain.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.Data;

public class MoviesContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=MoviesDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Movie> Movies => Set<Movie>();
}
