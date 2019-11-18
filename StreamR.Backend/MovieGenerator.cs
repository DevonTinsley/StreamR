using System;
using System.Collections.Generic;
using System.Text;

namespace StreamR.Backend
{
    public class MovieGenerator
    {
        //rename method for clarity
        public List<Movie> GenerateMovies(List<string> category , List<string> platforms ) {
            var moveRepository = new MovieRepository();
            var results = moveRepository.GetMoviesByCategory(category, platforms);

            return results;

        }
  
    }
}
