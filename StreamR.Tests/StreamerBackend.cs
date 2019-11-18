using StreamR.Backend;
using System;
using System.Collections.Generic;
using Xunit;

namespace StreamR.Tests
{
    public class StreamerBackend
    {
        [Fact]
        public void MovieGeneratorWorking()
        {
            //arrange
            MovieGenerator generator = new MovieGenerator();
            List<string> category = new List<string>();
            category.Add("Drama");

            List<string> platforms = new List<string>();
            platforms.Add("Netflix");

            //act
            var results = generator.GenerateMovies(category,platforms);


            Assert.Equal(3, results.Count);

        }
    }
}
