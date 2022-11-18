using System;
namespace SpaceXhistory.Models
{
    public class Fairings
    {
        public object reused { get; set; }
        public object recovery_attempt { get; set; }
        public object recovered { get; set; }
        public List<object> ships { get; set; }
    }
}

