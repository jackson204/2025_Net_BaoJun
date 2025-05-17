using Microsoft.EntityFrameworkCore;

namespace ConsoleDBContext;

class Program
{
    static async Task Main(string[] args)
    {
        var moviesContext = new ConsoleMoviesContext();
        await moviesContext.Database.EnsureDeletedAsync();
        await moviesContext.Database.EnsureCreatedAsync();
        var listAsync = await moviesContext.Movies.ToListAsync();
    }
}