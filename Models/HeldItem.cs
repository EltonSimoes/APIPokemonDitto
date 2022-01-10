using System.Collections.Generic;

namespace API.Models
{
    public class HeldItem
    {
        public Species Item { get; set; }
        public List<VersionDetail> VersionDetails { get; set; }
    }
}