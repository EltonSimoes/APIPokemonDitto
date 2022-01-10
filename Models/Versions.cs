using System.Collections.Generic;

namespace API.Models
{
    public class Versions
    {
        public GenerationI GenerationI { get; set; }
        public GenerationIi GenerationIi { get; set; }
        public GenerationIii GenerationIii { get; set; }
        public GenerationIv GenerationIv { get; set; }
        public GenerationV GenerationV { get; set; }
        public Dictionary<string, Home> GenerationVi { get; set; }
        public GenerationVii GenerationVii { get; set; }
        public GenerationViii GenerationViii { get; set; }
    }
}