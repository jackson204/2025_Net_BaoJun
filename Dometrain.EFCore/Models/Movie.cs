namespace Dometrain.EFCore.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }    
    public DateTime ReleaseDate { get; set; }
    public string? Synopsis { get; set; }
}

public class MovieTitle
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
}