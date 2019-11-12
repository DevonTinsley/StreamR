using StreamR.Backend;
using System;
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
            var category = "Drama";
           
            //act
            var results = generator.GenerateMovies(category);


            //asert 

            Assert.Single(results);

            Assert.Equal("The Shawshank Redemption", results[0].Title);

        }
    }
}
