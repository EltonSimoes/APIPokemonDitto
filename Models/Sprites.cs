using System;

namespace API.Models
{
    public class Sprites
    {
        public Uri BackDefault { get; set; }
        public object BackFemale { get; set; }
        public Uri BackShiny { get; set; }
        public object BackShinyFemale { get; set; }
        public Uri FrontDefault { get; set; }
        public object FrontFemale { get; set; }
        public Uri FrontShiny { get; set; }
        public object FrontShinyFemale { get; set; }
        public Other Other { get; set; }
        public Versions Versions { get; set; }
        public Sprites Animated { get; set; }
    }
}