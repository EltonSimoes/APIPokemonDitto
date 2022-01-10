using System.Collections.Generic;

namespace API.Models
{
    public class Move
    {
        public Species MoveMove { get; set; }
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}