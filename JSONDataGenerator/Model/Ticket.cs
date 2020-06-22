using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDataGenerator.Model
{
    public class Ticket
    {
        public Guid ticketId { get; set; }
        public string ticketType { get; set; }
        public float ticketPrice { get; set; }
        public Person person { get; set; }
        public FilmShow filmShow { get; set; }
    }
}
