using Weather_API.DTO;
using Weather_API.Models;

namespace Weather_API.Repositories.Interfaces
{
    public interface IWeatherRepository
    {
        
        Task<Weather> CreateWeather(WeatherDTO weather);
        Task<Weather> GetWeatherByCity(string city);
        Task<Weather> GetWeatherByCountry(string Country);
        Task<Weather> UpdateWeatherInfo(WeatherDTO weather, int id);
        Task<bool> DeleteWeatherInfo(int Id);
    }
}
