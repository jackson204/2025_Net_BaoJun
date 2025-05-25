using Dometrain.EFCore.Data.EntityMapping;
using Dometrain.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.Data;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies => Set<Movie>();

    public DbSet<Genre> Genres => Set<Genre>();

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    //     optionsBuilder.UseSqlServer("Server=localhost;Database=MoviesDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
    //     base.OnConfiguring(optionsBuilder);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GenreMapping());
        modelBuilder.ApplyConfiguration(new MovieMapping());
        base.OnModelCreating(modelBuilder);
    }
}
