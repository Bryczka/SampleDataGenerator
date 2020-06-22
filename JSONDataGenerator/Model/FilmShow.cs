using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDataGenerator.Model
{
    public class FilmShow
    {
        public Guid filmShowId { get; set; }
        public DateTime filmShowTime { get; set; }
        public string hallName { get; set; }
        public Film film { get; set; }
        public Cinema cinema { get; set; }
    }
}
