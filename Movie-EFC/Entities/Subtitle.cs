using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_EFC.Entities
{
    public class Subtitle
    {
        public int Id { get; set; }
        public string SubtitleLanguage { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
