using System;
namespace SpaceXhistory.Models
{
    public class Root
    {
        public Fairings fairings { get; set; }
        public Links links { get; set; }
        public object static_fire_date_utc { get; set; }
        public object static_fire_date_unix { get; set; }
        public bool net { get; set; }
        public object window { get; set; }
        public string rocket { get; set; }
        public object success { get; set; }
        public List<object> failures { get; set; }
        public object details { get; set; }
        public List<object> crew { get; set; }
        public List<object> ships { get; set; }
        public List<object> capsules { get; set; }
        public List<string> payloads { get; set; }
        public string launchpad { get; set; }
        public int flight_number { get; set; }
        public string name { get; set; }
        public DateTime date_utc { get; set; }
        public int date_unix { get; set; }
        public DateTime date_local { get; set; }
        public string date_precision { get; set; }
        public bool upcoming { get; set; }
        public List<Core> cores { get; set; }
        public bool auto_update { get; set; }
        public bool tbd { get; set; }
        public string launch_library_id { get; set; }
        public string id { get; set; }
    }
}

