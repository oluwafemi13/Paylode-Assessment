namespace Weather_API.DTO
{
    public class WeatherDTO
    {
        //public int Id { get; set; }
        public int TemperatureCelcius { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string City { get; set; } 
        public string Country { get; set; } 
        public string CloudFormation { get; set; }
        public string Description { get; set; }
    }
}
