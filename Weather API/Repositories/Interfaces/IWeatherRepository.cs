using Weather_API.Models;

namespace Weather_API.Repositories.Interfaces
{
    public interface IWeatherRepository
    {
        //Weather Get(int id);
        Task<Weather> CreateWeather(Weather weather);
        Task<Weather> GetWeatherByCity(string city);
        Task<Weather> GetWeatherByCountry(string Country);
        Task<bool> UpdateWeatherInfo(Weather weather);
        //Task<bool> DeleteWeather()
    }
}
