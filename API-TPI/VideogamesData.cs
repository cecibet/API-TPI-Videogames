using API_TPI.Models;

namespace API_TPI
{
    public class VideogamesData
    {
        public List<VideogameDto> Videogames { get; set; }

        public static VideogamesData ActualInstance { get; } = new VideogamesData();

        public VideogamesData()
        {
            Videogames = new List<VideogameDto>()
            {
                new VideogameDto()
                {
                     Id = 1,
                     Name = "Comix Zone",
                     Genre = "Beat 'em up.",
                     Platform = "Sega Genesis",
                     Reviews = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 1,
                             UserName = "Mike",
                             UserReview = "Comix Zone joined several of its 16-bit brethren in the release of SEGA Genesis" +
                             "Collection for the PS2 a few months ago. Other than that, opportunities to experience this game have been few and far between." +
                             "There's a genuine appeal to the premise of Comix Zone -- it's simply understood that the concept of having" +
                             "your own drawings come to life is totally awesome." },

                         new ReviewDto() {
                             Id = 2,
                             UserName = "Jane_1245",
                             UserReview = "Comix Zone is more than the sum of its parts." +
                             "The scrolling 'beat em up' genre is pretty much dead on its feet these days which is a" +
                             "shame when it can offer up gaming experiences as original and interesting as this." +
                             "This comes highly recommended." },
                     }
                },
                new VideogameDto()
                {
                    Id = 2,
                    Name = "Tekken 3",
                    Genre = "Fighting.",
                    Platform = "PlayStation",
                    Reviews = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 3,
                             UserName = "Ben-X",
                             UserReview = "Tekken 3 presents itself incredibly well. The sound effects are terrific, and the music is nothing short of amazing." +
                             "From a graphical standpoint, Tekken 3 can't be beat." +
                             "While the polygon count may have been slightly reduced and the backgrounds made 2D, it still looks absolutely incredible." +
                             "It is definitely the high water mark for graphics on the PlayStation." },

                         new ReviewDto() {
                             Id = 6,
                             UserName = "Susan",
                             UserReview = "I can not stress on how amazing this game is. For a PS1 game, this was easily in the Top 5 games of all time back then." +
                             "Tekken 3 still remains the best in the franchise next to Tekken 5." +
                             "For some odd reason, Namco decided to go multiplatform outside of the PlayStation brand." +
                             "Ever since that, Tekken hasn't been very good. Hopefully they will return back home where they belong." },
                     }
                },
                new VideogameDto()
                {
                    Id = 3,
                    Name = "Metroid",
                    Genre = "Action-adventure.",
                    Platform = "Nintendo",
                    Reviews = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 5,
                             UserName = "james",
                             UserReview = "I feel like this is a very good game but suffers from some faults that make it tedious and frustrating that bring it down." +
                             "I guess it has not aged well but it is no denying that it was groundbreaking at the time it came out and I" +
                             " have to score the game according to how the game plays today and it has next to none nostalgic value for me." },
                     }
                }
            };
        }

        internal static void Add(VideogameDto newVideogame)
        {
            throw new NotImplementedException();
        }
    }
}
