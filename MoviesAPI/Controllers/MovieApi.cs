using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieApi : ControllerBase
    {



        //constuer 
        public MovieApi()
        {
            //services gose in here

        }

        //GET API

        [HttpGet]
        public async Task<ActionResult <IEnumerable<MovieApi>>> GETALLMovies()
        {
            var movies = new List<MovieApi>();

                return Ok (movies);
        }
    }
}
