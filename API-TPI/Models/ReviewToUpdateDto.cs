using System.ComponentModel.DataAnnotations;

namespace API_TPI.Models
{
    public class ReviewToUpdateDto
    {
        [Required(ErrorMessage = "Please add your name")]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please add your review.")]
        [MaxLength(500)]
        public string? UserReview { get; set; }
    }
}
