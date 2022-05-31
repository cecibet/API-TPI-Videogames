namespace API_TPI.Models
{
    public class VideogameDto
    {
        internal readonly IEnumerable<object> Videogames;

        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public string? Genre { get; set; }
        public string? Platform { get; set; }

        public ICollection<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();

    }
}
