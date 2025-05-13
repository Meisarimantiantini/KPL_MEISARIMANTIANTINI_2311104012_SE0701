using Microsoft.AspNetCore.Mvc;
using modul9_2311104012.Models; 

namespace modul9_2311104012.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Director = "Frank Darabont", Stars = new List<string>{"Tim Robbins", "Morgan Freeman"}, Description = "Two imprisoned men bond over a number of years." },
            new Movie { Title = "The Godfather", Director = "Francis Ford Coppola", Stars = new List<string>{"Marlon Brando", "Al Pacino"}, Description = "The aging patriarch of an organized crime dynasty transfers control of his empire." },
            new Movie { Title = "The Dark Knight", Director = "Christopher Nolan", Stars = new List<string>{"Christian Bale", "Heath Ledger"}, Description = "When the menace known as the Joker wreaks havoc." }
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get() => Movies;

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            return Movies[id];
        }

        [HttpPost]
        public ActionResult<Movie> Post([FromBody] Movie movie)
        {
            Movies.Add(movie);
            return CreatedAtAction(nameof(Get), new { id = Movies.Count - 1 }, movie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            Movies.RemoveAt(id);
            return NoContent();
        }
    }
}
