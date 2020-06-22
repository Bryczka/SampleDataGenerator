using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDataGenerator.Model
{
    public class Person
    {
        public Guid personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
    }
}
