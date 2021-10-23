using MovieDbLib;
using MovieService.DTOs;
using System.Collections.Generic;
using System.Linq;

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
            return _movieDb.Movies.Select(x => new MovieDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Language = x.Language,
                Length = x.Length,
                AgeRestriction = x.AgeRestriction,
                ReleaseDate = x.ReleaseDate,
            })
            .ToList();
        }

        public MovieDto GetMovie(int id)
        {
            var movie = _movieDb.Movies.Find(id);

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Language = movie.Language,
                Length = movie.Length,
                AgeRestriction = movie.AgeRestriction,
                ReleaseDate = movie.ReleaseDate,
            };
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
    }
}
