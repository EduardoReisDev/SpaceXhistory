using System;
namespace SpaceXhistory.Models
{
    public class Root
    {
        public Links links { get; set; }
        public object success { get; set; }
        public string name { get; set; }
        public DateTime date_utc { get; set; }
        public DateTime date_local { get; set; }
        public bool upcoming { get; set; }
    }
}

