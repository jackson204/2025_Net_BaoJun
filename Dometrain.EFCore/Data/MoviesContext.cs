using Dometrain.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.Data;

public class MoviesContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();
}
