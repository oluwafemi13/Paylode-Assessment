using Weather_API.Models;
using Weather_API.Repositories.Interfaces;

namespace Weather_API.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public Task<Weather> CreateWeather(Weather weather)
        {
            throw new NotImplementedException();
        }

        public Task<Weather> GetWeatherByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Task<Weather> GetWeatherByCountry(string Country)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateWeatherInfo(Weather weather)
        {
            throw new NotImplementedException();
        }
    }
}
