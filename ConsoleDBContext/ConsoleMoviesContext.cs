using Microsoft.EntityFrameworkCore;

namespace ConsoleDBContext;

public class ConsoleMoviesContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ConsoleMoviesDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Movie> Movies => Set<Movie>();
}
