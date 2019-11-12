using System;
using System.Collections.Generic;
using System.Text;

namespace StreamR.Backend
{
    public class MovieGenerator
    {
        //rename method for clarity
        public List<Movie> GenerateMovies(string category) {
            var moveRepository = new MovieRepository();
            var results = moveRepository.GetMoviesByCategory(category);

            return results;

        }
  
    }
}
