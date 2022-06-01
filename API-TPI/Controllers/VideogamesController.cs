using API_TPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_TPI.Controllers
{
    [ApiController]
    [Route("api/videogames")]
    public class VideogamesController : ControllerBase //controller deriva de ControllerBase
    {


        [HttpGet]
        public ActionResult<IEnumerable<VideogameDto>> GetVideogames() //JsonResults implementa IActionResults
        {
            return Ok(VideogamesData.ActualInstance.Videogames);
        }

        [HttpGet("{id}")]
        public ActionResult<VideogameDto> GetVideogame(int id)
        {
            var videogameToReturn = VideogamesData.ActualInstance.Videogames.FirstOrDefault(x => x.Id == id);
            if (videogameToReturn == null)
                return NotFound();
            return Ok(videogameToReturn);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<VideogameDto> AddVideogame(VideogameToCreateDto videogame)
        {
            var idMaxReview = VideogamesData.ActualInstance.Videogames.Max(v => v.Id);

            var newVideogame = new VideogameDto
            {
                Id = ++idMaxReview,
                Name = videogame.Name,
                Genre = videogame.Genre,
                Platform = videogame.Platform,
            };

            VideogamesData.ActualInstance.Videogames.Add(newVideogame);

            return CreatedAtRoute(
                "GetVideogame",
                new
                {
                    Id = newVideogame.Id
                },
                newVideogame);
        }
    }
}
