using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StreamR.Backend
{
    public class MovieRepository
    {

        List<Movie> movieRepo = new List<Movie>();
        public MovieRepository()
        {
            var ShawShank = new Movie()
            {
                Title = "The Shawshank Redemption",
                Id = 1,
                Categories = new List<string>() { 
                    "Drama" 
                },
                Synopsis = "Andy Dufresne(Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison.However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years." ,

               StreamingPlatforms = new List<string>() { 
                    "Netflix",
                    "Amazon Prime"
                },
              
                ImageURL = "https://images-na.ssl-images-amazon.com/images/I/519NBNHX5BL.SY445.jpg",
                LengthInMinutes = 142,
                Rating = "R"
                
            };
            movieRepo.Add(ShawShank);
            var AStarIsBorn = new Movie()
            {
                Title = "A Star Is Born",
                Id = 2,
                Categories = new List<string>() {
                    "Drama"
                },
                Synopsis = "Seasoned musician Jackson Maine discovers -- and falls in love with -- struggling artist Ally. She has just about given up on her dream to make it big as a singer until Jackson coaxes her into the spotlight. But even as Ally's career takes off, the personal side of their relationship is breaking down, as Jackson fights an ongoing battle with his own internal demons.",
                StreamingPlatforms = new List<string>() {
                    "HBO",
                    "Amazon Prime"
                },
                ImageURL = "http://www.gstatic.com/tv/thumb/v22vodart/14603082/p14603082_v_v8_ac.jpg",
                LengthInMinutes = 142,
                Rating = "R"
            };
            movieRepo.Add(AStarIsBorn);
            var VForVendetta = new Movie()
            {
                Title = "V For Vendetta",
                Id = 3,
                Categories = new List<string>() {
                    "Drama",
                    "Action"
                },
                Synopsis = "Following world war, London is a police state occupied by a fascist government, and a vigilante known only as V (Hugo Weaving) uses terrorist tactics to fight the oppressors of the world in which he now lives. When V saves a young woman named Evey (Natalie Portman) from the secret police, he discovers an ally in his fight against England's oppressors.",
                StreamingPlatforms = new List<string>() {
                    "Netflix",
                    "Amazon Prime"
                },
                ImageURL = "https://miro.medium.com/max/1189/1*Etx-JkqJ5fGz9DnwLVlzNA.jpeg",
                LengthInMinutes = 142,
                Rating = "PG-13"
            };
            movieRepo.Add(VForVendetta);
            var KilledHitlerAndBigfoot = new Movie()
            {
                Title = "The Man Who Killed Hitler And Then Bigfoot",
                Id = 4,
                Categories = new List<string>() {
                    "Drama",
                    "Action"
                },
                Synopsis = "It's in the name, he killed hitler AND bigfoot.",
                StreamingPlatforms = new List<string>() {
                    "Hulu",
                    "Amazon Prime"
                },
               ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81-%2BUBBOP4L._SL1500_.jpg",
            
                LengthInMinutes = 93,
                Rating = "PG-13"
            };
            movieRepo.Add(KilledHitlerAndBigfoot);
            var Juno = new Movie()
            {
                Title = "Juno",
                Id = 5,
                Categories = new List<string>() {
                    "Comedy",
                    "Drama"
                },
                Synopsis = "When precocious teen Juno MacGuff (Ellen Page) becomes pregnant, she chooses a failed rock star and his wife (Jennifer Garner) to adopt her unborn child. Complications occur when Mark, the prospective father, begins viewing Juno as more than just the mother of his future child, putting both his marriage and the adoption in jeopardy.",
                StreamingPlatforms = new List<string>() {
                    "Hulu",
                    "Amazon Prime"
                },
                ImageURL = "https://ib1.hulu.com/user/v3/artwork/8a8294de-f49b-42a0-9672-d04a4516f465?base_image_bucket_name=image_manager&base_image=d97a8f87-7438-4038-bac9-0cf826656d16&size=400x600&format=jpeg",
                LengthInMinutes = 93,
                Rating = "PG-13"
            };
            movieRepo.Add(Juno);
            var Equals = new Movie()
            {
                Title = "Equals",
                Id = 5,
                Categories = new List<string>() {
                
                    "Drama"
                },
                Synopsis = "I'll do this later",
                StreamingPlatforms = new List<string>() {
                    "Netflix",
                    "Amazon Prime"
                },
                
                 ImageURL = "https://ib1.hulu.com/user/v3/artwork/8a8294de-f49b-42a0-9672-d04a4516f465?base_image_bucket_name=image_manager&base_image=d97a8f87-7438-4038-bac9-0cf826656d16&size=400x600&format=jpeg",
                LengthInMinutes = 93
            };
            movieRepo.Add(Juno);

        }
        //read
        public List<Movie> GenerateMovies(List<string> categories, List<string> platforms) {
            var moviesByCategory = movieRepo.Where(x => x.Categories.Any(y => categories.Contains(y)));
            var filteredMovies = moviesByCategory.Where(x => x.StreamingPlatforms.Any( y=> platforms.Contains(y))).ToArray();
            var results = new List<Movie>();
            var addedMovies = new List<int>();
            for (int i = 0 ; i < 3 ; i++) {

                var rand = new Random();
                var index = rand.Next(filteredMovies.Length);
                if (!addedMovies.Contains(index))
                {
                    results.Add(filteredMovies[index]);
                    addedMovies.Add(index);

                }
                else i--;
                
            
            }

            return results;

        }
        //public List<Movie> GetMoviesByPlatform(List<string> platforms , List<Movie> movies) {

       
        //    return results;

        //}

        public Movie GetMovie(string title) {
            return movieRepo.Where(x => x.Title == title).FirstOrDefault();

        }

        

    }
}
