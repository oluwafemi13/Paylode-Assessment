using System.Data;

namespace Weather_API.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public int TemperatureCelcius { get; set; }
        public DateTime Date{ get; set; } 
        public string City { get; set; }
        public string Country { get; set; }
        public string CloudFormation { get; set; }
        public string  Description { get; set; }
    }
}

//temperature, atmospheric pressure, cloud formation, wind, humidity and rain