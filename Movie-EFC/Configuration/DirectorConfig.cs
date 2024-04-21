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
    public class DirectorConfig : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnType("nvarchar");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnType("nvarchar");

            builder.Property(x => x.DateOfBirth)
                .IsRequired()
                .HasColumnType("date");

            builder.HasMany(x => x.Movies)
                .WithOne(x => x.Director)
                .HasForeignKey(x => x.DirectorId);



        }
    }
}
