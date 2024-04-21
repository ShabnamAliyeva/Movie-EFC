using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_EFC.Entities
{
    public class Movie
    {
        //Data Annotation
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string Description { get; set; }
        public int DirectorId { get; set; }
        [ForeignKey(nameof(DirectorId))]
        public Director Director { get; set; }
        public MoviesImdbDetail MoviesImdbDetail { get; set; }
        public ICollection<Subtitle> Subtitles { get; set; }
    }
}
