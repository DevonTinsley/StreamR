using System;
using System.Collections.Generic;

namespace StreamR.Backend
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Categories { get; set; }
        public string Synopsis { get; set; }
        public int LengthInMinutes { get; set; }
        public string ImageURL { get; set; }
        public List<string> StreamingPlatforms { get; set; }

    }
}
