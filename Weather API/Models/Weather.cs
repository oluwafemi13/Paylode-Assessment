using System.Data;

namespace Weather_API.Models
{
    public class Weather
    {
        //public int Id { get; set; }
        public int TemperatureCelcius { get; set; }
        public DateTime Date{ get; set; } = DateTime.Now;
        public string City { get; set; } = "Lagos";
        public string Country { get; set; } = "Nigeria";
        public string CloudFormation { get; set; }
        public string  Description { get; set; }
    }
}

//temperature, atmospheric pressure, cloud formation, wind, humidity and rain