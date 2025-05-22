using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dometrain.EFCore.Models;

[Table("Pictures")]
public class Movie
{
    [Key]
    public int Identifier { get; set; }
    
    [Column("Title" , TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string? Title { get; set; }    
    public DateTime ReleaseDate { get; set; }
    public string? Synopsis { get; set; }
}

public class MovieTitle
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
}