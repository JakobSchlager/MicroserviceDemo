using System; 
using MovieDbLib;
using MovieDbLib.Entities;
using MovieService.DTOs;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MovieService.Services
{
    public class MovieService
    {
        private readonly MovieDbContext _movieDb;

        public MovieService(MovieDbContext movieDb)
        {
            this._movieDb = movieDb;
        }

        public List<MovieDto> GetMovies()
        {
            return _movieDb.Movies.Select(x => MapToMovieDto(x))
            .ToList();
        }

        public MovieDto GetMovie(int id)
        {
            var movie = _movieDb.Movies.Find(id);
            if (movie == null) throw new Exception($"No movie with id: {id} exists."); 

            return MapToMovieDto(movie); 
        }

        public ActionResult<MovieDto> AddMovie(MovieDto movieDto)
        {
            var movie = _movieDb.Movies.Add(new Movie
            {
                Id = 0, 
                Title = movieDto.Title,
                Description = movieDto.Description,
                Language = movieDto.Language,
                Length = movieDto.Length,
                AgeRestriction = movieDto.AgeRestriction,
                ReleaseDate = movieDto.ReleaseDate,
                Image = movieDto.Image, 
            }).Entity;

            _movieDb.SaveChanges();

            return MapToMovieDto(movie); 
        }

        public List<PresentationDto> GetPresentationsOfMovie(int id)
        {
            return _movieDb.Presentations.Where(x => x.MovieId == id).Select(x => new PresentationDto
            {
                Id = x.Id,
                MovieId = x.MovieId,
                RoomId = x.RoomId,
                StartTime = x.StartTime,
            })
            .ToList();
        }

        private static MovieDto MapToMovieDto(Movie movie) =>
            new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Language = movie.Language,
                Length = movie.Length,
                AgeRestriction = movie.AgeRestriction,
                ReleaseDate = movie.ReleaseDate,
                Image = movie.Image, 
            };
    }
}
