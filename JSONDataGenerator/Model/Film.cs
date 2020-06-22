using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDataGenerator.Model
{
    public class Film
    {
        public Guid filmId { get; set; }
        public string title { get; set; }
        public string filmDescription { get; set; }
        public int duration { get; set; }
        public int ageLimit { get; set; }
    }
}
