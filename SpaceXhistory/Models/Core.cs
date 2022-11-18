using System;
namespace SpaceXhistory.Models
{
    public class Core
    {
        public string core { get; set; }
        public int flight { get; set; }
        public bool gridfins { get; set; }
        public bool legs { get; set; }
        public bool reused { get; set; }
        public object landing_attempt { get; set; }
        public object landing_success { get; set; }
        public object landing_type { get; set; }
        public object landpad { get; set; }
    }
}

