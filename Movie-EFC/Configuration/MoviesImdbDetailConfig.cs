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
    public class MoviesImdbDetailConfig : IEntityTypeConfiguration<MoviesImdbDetail>
    {
        public void Configure(EntityTypeBuilder<MoviesImdbDetail> builder)
        {
            builder.Property(x => x.ImdbPoint)
                .IsRequired();

            //builder.HasIndex(x => x.MovieId)
            //    .IsUnique();


        }
    }
}
