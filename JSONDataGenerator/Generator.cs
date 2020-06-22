using JSONDataGenerator.Model;
using System;
using System.Collections.Generic;

namespace JSONDataGenerator
{
    public class Generator
    {
        public List<Ticket> Generate(int peopleCount, int filmshowCount, int ticketCount, int filmsCount, int cinemasCount)
        {
            var random = new Random();
            var people = GeneratePeople(peopleCount, random);
            var filmshows = GenerateFilmshows(filmshowCount, filmsCount, cinemasCount, random);

            List<Ticket> tickets = new List<Ticket>();
            for (int i = 0; i < ticketCount; i++)
            {
                var Ticket = new Ticket
                {
                    ticketId = Guid.NewGuid(),
                    person = people[random.Next(0, people.Count - 1)],
                    filmShow = filmshows[random.Next(0, filmshows.Count - 1)],
                    ticketPrice = random.Next(10, 40),
                    ticketType = Values.ticketType[random.Next(0, Values.ticketType.Count - 1)].ToString(),
                };
                tickets.Add(Ticket);
            }
            Console.WriteLine("Tickets:" + tickets.Count);
            return tickets;
        }

        private List<FilmShow> GenerateFilmshows(int filmshowsCount, int filmsCount, int cinemasCount, Random random)
        {
            var films = GenerateFilms(filmsCount, random);
            var cinemas = GenerateCinemas(cinemasCount, random);
            List<FilmShow> filmshows = new List<FilmShow>();
            for (int i = 0; i < filmshowsCount; i++)
            {
                var filmshow = new FilmShow
                {
                    filmShowId = Guid.NewGuid(),
                    film = films[random.Next(0, films.Count - 1)],
                    cinema = cinemas[random.Next(0, cinemas.Count - 1)],
                    filmShowTime = DateTime.Now.AddDays(random.Next(0, 30)).AddHours(random.Next(0, 24)),
                    hallName = Values.hallNames[random.Next(0, Values.hallNames.Count - 1)].ToString()
                };
                filmshows.Add(filmshow);
            }
            Console.WriteLine("Filmshows:" + filmshows.Count);
            return filmshows;
        }

        private List<Cinema> GenerateCinemas(int count, Random random)
        {
            List<Cinema> cinemas = new List<Cinema>();
            for (int i = 0; i < count; i++)
            {
                var cinema = new Cinema
                {
                    cinemaId = Guid.NewGuid(),
                    city = Values.cities[random.Next(0, Values.cities.Count - 1)].ToString(),
                    street = Values.streets[random.Next(0, Values.streets.Count - 1)].ToString()
                };
                cinemas.Add(cinema);
            }
            Console.WriteLine("Cinemas:" + cinemas.Count);
            return cinemas;
        }

        private List<Film> GenerateFilms(int count, Random random)
        {
            List<Film> films = new List<Film>();
            for (int i = 0; i < count; i++)
            {
                var film = new Film
                {
                    filmId = Guid.NewGuid(),
                    title = Values.filmTitles[random.Next(0, Values.filmTitles.Count - 1)].ToString(),
                    filmDescription = Values.filmDescriptions[random.Next(0, Values.filmDescriptions.Count - 1)].ToString(),
                    ageLimit = (int)Values.ageLimits[random.Next(0, Values.ageLimits.Count - 1)],
                    duration = random.Next(60, 250)
                };
                films.Add(film);
            }
            Console.WriteLine("Films:" + films.Count);
            return films;
        }

        private List<Person> GeneratePeople(int count, Random random)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var person = new Person
                {
                    personId = Guid.NewGuid(),
                    firstName = Values.firstNames[random.Next(0, Values.firstNames.Count - 1)].ToString(),
                    lastName = Values.lastNames[random.Next(0, Values.lastNames.Count - 1)].ToString(),
                    birthDate = new DateTime(1940, 1, 1).Date.AddDays(random.Next(0, 28000))
                };
                people.Add(person);
            }
            Console.WriteLine("People:" + people.Count);
            return people;
        }
    }
}
