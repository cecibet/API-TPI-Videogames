using API_TPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_TPI.Controllers
{
    [ApiController]
    [Route("api/videogames/{idVideogame}/reviews")]
    public class ReviewsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ReviewDto>> GetReviews(int idVideogame)
        {
            var videogame = VideogamesData.ActualInstance.Videogames.FirstOrDefault(x => x.Id == idVideogame);
            if (videogame == null)
                return NotFound();

            return Ok(videogame.Reviews);
        }

        [HttpGet("{idReview}", Name = "GetReviews")]
        public ActionResult<ReviewDto> GetReview(int idVideogame, int idReview)
        {
            var videogame = VideogamesData.ActualInstance.Videogames.FirstOrDefault(x => x.Id == idVideogame);

            if (videogame == null)
                return NotFound();

            var review = videogame.Reviews.FirstOrDefault(x => x.Id == idReview);

            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpPost]
        public ActionResult<ReviewDto> AddReview(int idVideogame, ReviewToCreateDto review)
        {
            var videogame = VideogamesData.ActualInstance.Videogames.FirstOrDefault(v => v.Id == idVideogame);
            if (videogame is null)
            {
                return NotFound();
            }

            var idMaxReview = VideogamesData.ActualInstance.Videogames.SelectMany(v => v.Reviews).Max(p => p.Id);

            var newReview = new ReviewDto
            {
                Id = ++idMaxReview,
                UserName = review.UserName,
                UserReview = review.UserReview,
            };

            videogame.Reviews.Add(newReview);

            return CreatedAtRoute(
                "GetReview", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros que necesita ese endpoint
                {
                    idVideogame,
                    idReview = newReview.Id
                },
                newReview);
        }

        [HttpPut("{idReview}")]
        public ActionResult UpdateReview(int idVideogame, int idReview, ReviewToUpdateDto review)
        {
            var videogame = VideogamesData.ActualInstance.Videogames.FirstOrDefault(v => v.Id == idVideogame);

            if (videogame == null)
                return NotFound();

            var baseReview = videogame.Reviews.FirstOrDefault(p => p.Id == idReview);
            if (baseReview == null)
                return NotFound();

            baseReview.UserName = review.UserName;
            baseReview.UserReview = review.UserReview;

            return NoContent();
        }


        [HttpDelete("{idReview}")]
        public ActionResult DeleteReview(int idVideogame, int idReview)
        {
            var videogame = VideogamesData.ActualInstance.Videogames.FirstOrDefault(v => v.Id == idVideogame);
            if (videogame is null)
                return NotFound();

            var reviewToDelete = videogame.Reviews
                .FirstOrDefault(p => p.Id == idReview);
            if (reviewToDelete is null)
                return NotFound();

            videogame.Reviews.Remove(reviewToDelete);

            return NoContent();
        }
    }
}
