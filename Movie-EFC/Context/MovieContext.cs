using Microsoft.EntityFrameworkCore;
using Movie_EFC.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Movie_EFC.Context
{
    internal class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HONOR-MAGICBOOK\SQLEXPRESS;Database=MovieEFC;
                                          Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MoviesImdbDetail> MoviesImdbDetails { get; set; }
        public DbSet<Subtitle> Subtitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
