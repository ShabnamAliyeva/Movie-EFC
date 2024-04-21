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
    public class SubtitleConfig : IEntityTypeConfiguration<Subtitle>
    {
        public void Configure(EntityTypeBuilder<Subtitle> builder)
        {
            builder.Property(x => x.SubtitleLanguage)
                .IsRequired()
               .HasMaxLength(80)
               .HasColumnType("nvarchar");
        }
    }
}
