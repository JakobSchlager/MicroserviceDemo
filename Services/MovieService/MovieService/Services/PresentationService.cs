using Microsoft.AspNetCore.Mvc;
using MovieDbLib;
using MovieDbLib.Entities;
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

        public PresentationDto GetSinglePresentations(int id)
        {
            return _movieDb.Presentations.Select(x => new PresentationDto
            {
                Id = x.Id,
                MovieId = x.MovieId,
                RoomId = x.RoomId,
                StartTime = x.StartTime,
            })
            .Single(x => x.Id == id);
        }

        public ActionResult<PresentationDto> AddPresentation(PresentationDto presentationDto)
        {
            var presentation = _movieDb.Presentations.Add(new Presentation
            {
                Id = 0,
                MovieId = presentationDto.MovieId,
                RoomId = presentationDto.RoomId,
                StartTime = presentationDto.StartTime,
            }).Entity;

            _movieDb.SaveChanges();

            return MapToPresentationDto(presentation);
        }

        private static PresentationDto MapToPresentationDto(Presentation presentation) =>
            new PresentationDto
            {
                Id = presentation.Id,
                MovieId = presentation.MovieId,
                RoomId = presentation.RoomId,
                StartTime = presentation.StartTime,
            };
    }
}
