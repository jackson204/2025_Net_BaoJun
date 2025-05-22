using Dometrain.EFCore.Data;
using Dometrain.EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : Controller
{
    private readonly MoviesContext _context;

    public MoviesController(MoviesContext context)
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Movie>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var movies = await _context.Movies.ToListAsync();
        return Ok(movies);
    }

    [HttpGet("by-year/{year:int}")]
    [ProducesResponseType(typeof(List<MovieTitle>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllByYear([FromRoute] int year)
    {
        // var movies = _context.Movies
        //     .Where(movie => movie.ReleaseDate.Year == year);
        //
        // var movieTitles = new List<MovieTitle>();
        // foreach (var movie in movies)
        // {
        //     movieTitles.Add(new MovieTitle()
        //     {
        //         Id = movie.Id,
        //         Title = movie.Title
        //     });
        // }
        // return Ok(movieTitles);
        var movies = await _context.Movies
            .Where(movie => movie.ReleaseDate.Year == year)
            .Select(movie => new MovieTitle
            {
                Id = movie.Identifier,
                Title = movie.Title
            }).ToListAsync();
        return Ok(movies);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(Movie), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(movie => movie.Identifier == id);
        return movie is null ? NotFound() : Ok(movie);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Movie), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = movie.Identifier }, movie);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(Movie), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Movie movie)
    {
        var firstOrDefaultAsync = await _context.Movies.FirstOrDefaultAsync(movie1 => movie1.Identifier == id);
        if (firstOrDefaultAsync is null)
        {
            return NotFound();
        }
        firstOrDefaultAsync.Title = movie.Title;
        firstOrDefaultAsync.ReleaseDate = movie.ReleaseDate;
        firstOrDefaultAsync.Synopsis = movie.Synopsis;
        await _context.SaveChangesAsync();
        return Ok(firstOrDefaultAsync);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Remove([FromRoute] int id)
    {
        var firstOrDefaultAsync = await _context.Movies.FirstOrDefaultAsync(movie => movie.Identifier == id);
        if (firstOrDefaultAsync is null)
        {
            return NotFound();
        }
        _context.Remove(firstOrDefaultAsync);
        await _context.SaveChangesAsync();
        return Ok();
    }
}
