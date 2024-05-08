using ASP_MVC_Cinema.Models.Builders;
using System;
using System.Collections.Generic;

namespace ASP_MVC_Cinema.Models
{
    public class CinemaModel
    {
        public int Id { get; set; }
        public DateTime RentalCompletion {  get; set; }
        public List<MovieModel> Movies { get; set; }
        public Dictionary<DateTime, MovieModel> Sessions { get; set; }

        public CinemaModel() 
        {
            this.Movies = FillMovies(10);
            this.Sessions = FillSessions(15);
        }

        public Dictionary<DateTime, MovieModel> FillSessions(int sessionsCount)
        {
            Random random = new Random();
            Dictionary<DateTime, MovieModel> _sessions = new Dictionary<DateTime, MovieModel>();

            for (int i = 0; i < sessionsCount; i++)
            {
                DateTime randomKey = DateTime.Now.AddDays(random.Next(1, sessionsCount));

                if (_sessions.ContainsKey(randomKey))
                {
                    continue;
                }

                _sessions[randomKey] = Movies[random.Next(Movies.Count)];
            }

            return _sessions;
        }

        public List<MovieModel> FillMovies(int moviesCount)
        {
            Random random = new Random();
            List<MovieModel> _movies = new List<MovieModel>();

            for (int i = 1; i <= moviesCount; i++)
            {
                _movies.Add(new MovieModelBuilder()
                    .WithId(i)
                    .WithTitle($"Title{i}")
                    .WithDirector($"Director{i}")
                    .WithDescription($"Description for Movie{i}")
                    .WithGenre($"Genre{i}")
                    .WithReleaseDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month + random.Next(1, 3), DateTime.Now.Day + random.Next(4, 11)))
                    .Build());
            }

            return _movies;
        }

        public override string ToString()
        {
            string sessionsInfo = "Sessions:\n";

            foreach (var item in Sessions)
            {
                sessionsInfo += $" Date: {item.Key} - Movie: {item.Value}\n";
            }

            return $"Id: {this.Id}\n" + 
                   $"Rental Completion: {this.RentalCompletion}\n" +
                   sessionsInfo;
        }
    }
}
