using System.ComponentModel.DataAnnotations;


namespace API_TPI.Models
{
    public class VideogameToCreateDto
    {
        [Required(ErrorMessage = "Please add the videogame's name")]
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please add the genre.")]
        [MaxLength(30)]
        public string? Genre { get; set; }
        [Required(ErrorMessage = "Please add the platform.")]
        [MaxLength(30)]
        public string? Platform { get; set; }
    }
}