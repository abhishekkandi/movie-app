using Microsoft.AspNetCore.Mvc;

using Movie.API.Models.Filter;
using Movie.API.Services;

namespace Movie.API.Controllers
{
    public class MovieController : ControllerBase
    {
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]   
        [Route("api/Movies")]
        public IActionResult GetMovies([FromQuery]MovieFilter filter)
        {
            return Ok(_movieRepository.GetMovies(filter));
        }
    }
}
