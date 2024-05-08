using System;

namespace ASP_MVC_Cinema.Models.Builders
{
    public class MovieModelBuilder
    {
        private readonly MovieModel _movie;

        public MovieModelBuilder()
        {
            _movie = new MovieModel();
        }

        public MovieModelBuilder WithId(int id)
        {
            _movie.Id = id;
            return this;
        }

        public MovieModelBuilder WithTitle(string title)
        {
            _movie.Title = title;
            return this;
        }

        public MovieModelBuilder WithDirector(string director)
        {
            _movie.Director = director;
            return this;
        }

        public MovieModelBuilder WithDescription(string description)
        {
            _movie.Description = description;
            return this;
        }

        public MovieModelBuilder WithGenre(string genre)
        {
            _movie.Genre = genre;
            return this;
        }

        public MovieModelBuilder WithReleaseDate(DateTime releaseDate)
        {
            _movie.ReleaseDate = releaseDate;
            return this;
        }

        public MovieModel Build()
        {
            return _movie;
        }
    }
}
