using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie_EFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_EFC.Configuration
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        //Fluent API
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(x => x.MovieName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(x => x.MovieReleaseDate)
                .IsRequired()
                .HasColumnType("datetime2");

            builder.Property(x => x.Description)
                .IsRequired(false);

            builder.HasOne(x => x.MoviesImdbDetail)
                .WithOne(x => x.Movie)
                .HasForeignKey<MoviesImdbDetail>(x => x.MovieId);


        }
    }
}
