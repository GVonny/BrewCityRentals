﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Movie
    {
        public Guid MovieID { get; set; }

        [DisplayName("Genre")]
        public Guid GenreID { get; set; }

        public int MovieCode { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public int QuantityAvailabe { get; set; }

        public DateTime ReleaseDate { get; set; }

        [NotMapped]
        public List<Genre> Genres { get; set; }
    }

    public class MovieList
    {
        public MovieList() { }

        public List<Movie> GetMovies()
        {
            List<Movie> Movies = new List<Movie>()
            {
                new Movie { MovieID = Guid.NewGuid(), GenreID = new Guid("1994ea36-1acf-4dcb-8b27-aa108b649f9d"), MovieCode = 1234, Title = "Movie 1", Rating = "R", QuantityAvailabe = 5, ReleaseDate = DateTime.Now.AddDays(-283) },
            };
            return Movies;
        }

        public List<Movie> SearchMovies(Movie Movie)
        {
            List<Movie> AllMovies = GetMovies();
            List<Movie> Movies = new List<Movie>();

            foreach(var movie in AllMovies)
            {
                if((movie.GenreID == Movie.GenreID) || !movie.Title.Contains(Movie.Title))
                {
                    Movies.Add(movie);
                }
            }
            return Movies;
        }
    }
}