using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StreamR.Backend
{
    class MovieRepository
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
                Synopsis = "The greatest movie of all time ever if you disagree uninstall my app." ,
                StreamingPlatforms = new List<string>() { 
                    "Netflix",
                    "Amazon Prime"
                },
                ImageURL = "https://images-na.ssl-images-amazon.com/images/I/519NBNHX5BL._SY445_.jpg",
                LengthInMinutes = 142
            };
            movieRepo.Add(ShawShank);
            var AStarIsBorn = new Movie()
            {
                Title = "A Star Is Born",
                Id = 2,
                Categories = new List<string>() {
                    "Drama"
                },
                 Synopsis = "I'll def add these later probably",
                StreamingPlatforms = new List<string>() {
                    "HBO",
                    "Amazon Prime"
                },
                ImageURL = "http://www.gstatic.com/tv/thumb/v22vodart/14603082/p14603082_v_v8_ac.jpg",
                LengthInMinutes = 142
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
                Synopsis = "I'll def add these later probably",
                StreamingPlatforms = new List<string>() {
                    "Netflix",
                    "Amazon Prime"
                },
                ImageURL = "https://miro.medium.com/max/1189/1*Etx-JkqJ5fGz9DnwLVlzNA.jpeg",
                LengthInMinutes = 142
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
                ImageURL = "http://www.gstatic.com/tv/thumb/v22vodart/16443570/p16443570_v_v8_aa.jpg",
                LengthInMinutes = 93
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
                Synopsis = "I'll do this later",
                StreamingPlatforms = new List<string>() {
                    "Hulu",
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
            for (int i = 0 ; i < 2 ; i++) {

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

        public Movie GetMovie(int id) {
            return movieRepo.Where(x => x.Id == id).FirstOrDefault();

        }

        

    }
}
