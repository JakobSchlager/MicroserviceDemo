using MovieDbLib;
using MovieService.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace MovieService.Services
{
    public class PresentationService
    {
        private readonly MovieDbContext _movieDb;

        public PresentationService(MovieDbContext movieDb)
        {
            this._movieDb = movieDb;
        }

        public List<PresentationDto> GetPresentations()
        {
            return _movieDb.Presentations.Select(x => new PresentationDto
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
