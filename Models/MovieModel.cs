using System;

namespace ASP_MVC_Cinema.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return $"Title: {this.Title}\n" +
                   $"Genre: {this.Genre}\n" + 
                   $"Director: {this.Director}\n" +
                   $"Release Date: {this.ReleaseDate.ToShortDateString()}\n" +
                   $"Description: {this.Description}\n";
        }
    }
}
