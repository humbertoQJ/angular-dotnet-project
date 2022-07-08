using back_end.Models;
using back_end.Repository;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : Controller
    {
        private readonly MoviesRepository movies;
        public MovieController()
        {
            this.movies = new MoviesRepository();
        }
        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            var movies = this.movies.getAllMovies();
            if (movies == null)
            {
                return NotFound();
            }
            return movies;
        }

        [HttpGet("{Id}")]
        public ActionResult<Movie> GetMovieById(int Id)
        {
            var movie = this.movies.getMovieById(Id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
    }
}
