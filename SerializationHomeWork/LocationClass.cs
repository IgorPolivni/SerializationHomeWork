using System;

namespace JsonHomeWork
{
    public class LocationClass
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone_id { get; set; }
        public DateTime Localtime { get; set; }
        public long Localtime_epoch { get; set; }
        public double Utc_offset { get; set; }
    }
}
