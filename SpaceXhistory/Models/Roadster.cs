using System;
namespace SpaceXhistory.Models
{
	public class Roadster
	{
        public string name { get; set; }
        public DateTime launch_date_utc { get; set; }
        public int launch_date_unix { get; set; }
        public int launch_mass_kg { get; set; }
        public int launch_mass_lbs { get; set; }
        public int norad_id { get; set; }
        public double epoch_jd { get; set; }
        public string orbit_type { get; set; }
        public double apoapsis_au { get; set; }
        public double periapsis_au { get; set; }
        public double semi_major_axis_au { get; set; }
        public double eccentricity { get; set; }
        public double inclination { get; set; }
        public double longitude { get; set; }
        public double periapsis_arg { get; set; }
        public double period_days { get; set; }
        public double speed_kph { get; set; }
        public double speed_mph { get; set; }
        public double earth_distance_km { get; set; }
        public double earth_distance_mi { get; set; }
        public double mars_distance_km { get; set; }
        public double mars_distance_mi { get; set; }
        public List<string> flickr_images { get; set; }
        public string wikipedia { get; set; }
        public string video { get; set; }
        public string details { get; set; }
        public string id { get; set; }
    }
}

