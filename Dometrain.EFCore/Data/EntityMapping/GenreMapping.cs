using Dometrain.EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dometrain.EFCore.Data.EntityMapping;

public class GenreMapping : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        // builder.ToTable("Genres").HasKey(e => e.Id);

        builder.HasData(new Genre()
        {
            Id = 1,
            Name = "Drama"
        });
    }
}
