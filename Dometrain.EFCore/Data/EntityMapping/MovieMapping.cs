using Dometrain.EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dometrain.EFCore.Data.EntityMapping;

public class MovieMapping:IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.ToTable("Pictures").HasKey(e => e.Identifier);
     
        builder.Property(e => e.Title).IsRequired().HasColumnType("varchar").HasMaxLength(128);
        builder.Property(e => e.ReleaseDate).HasColumnType("date");
        builder.Property(e => e.Synopsis).HasColumnType("varchar(max)").HasColumnName("Plot");
    }
}
