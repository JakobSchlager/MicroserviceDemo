using Microsoft.AspNetCore.Mvc;
using MovieService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieService.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly Services.MovieService _movieService;

        public MovieController(Services.MovieService movieSerives)
        {
            this._movieService = movieSerives; 
        }

        [HttpGet]
        public ActionResult<List<MovieDto>> GetAll()
        {
            return Ok(_movieService.GetMovies());  
        }

        [HttpGet("{id}")]
        public ActionResult<MovieDto> Get(int id)
        {
            return (_movieService.GetMovie(id));
        }

        [HttpPost]
        public ActionResult<MovieDto> Post([FromBody] MovieDto movieDto)
        {
            return (_movieService.AddMovie(movieDto)); 
        }

        [HttpGet("{id}/presentations")]
        public ActionResult<List<PresentationDto>> GetPresentationsOfMovie(int id)
        {
            return (_movieService.GetPresentationsOfMovie(id)); 
        }
    }
}
