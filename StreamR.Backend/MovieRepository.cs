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
                Title = "The ShawShank Redemption",
                Id = 1,
                Categories = new List<string>() { 
                    "Drama" 
                },
            };


        }
        //read
        public List<Movie> GetMovies() {
            //returns all movies
            return movieRepo;


        }
        public List<Movie> GetMoviesByCategory(string category) {


            return movieRepo.Where(x => x.Categories.Any( y => y == category) ).ToList();
        }


        public Movie GetMovie(int id) {
            return movieRepo.Where(x => x.Id == id).FirstOrDefault();

        }

        

    }
}
