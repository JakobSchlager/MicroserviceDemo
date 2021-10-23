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
            return _movieService.GetMovies(); 
        }

        [HttpGet("{id}")]
        public ActionResult<MovieDto> Get(int id)
        {
            return _movieService.GetMovie(id);
        }

        [HttpGet("{id}/presentations")]
        public ActionResult<List<PresentationDto>> GetPresentationsOfMovie(int id)
        {
            return _movieService.GetPresentationsOfMovie(id); 
        }
        
        /* 
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
