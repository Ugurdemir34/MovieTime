using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTime.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTime.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet("getmovies")]
        public async Task<IActionResult> GetMovies()
        {
            var model =await _movieService.GetAll();
            if(model.Success)
            {
                return Ok(model);
            }
            return BadRequest(model.Message);
        }
    }
}
