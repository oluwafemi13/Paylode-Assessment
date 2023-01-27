using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Weather_API.Data;
using Weather_API.DTO;
using Weather_API.Models;
using Weather_API.Repositories.Interfaces;

namespace Weather_API.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<WeatherRepository> _logger;

        public WeatherRepository(DatabaseContext context, IMapper mapper, ILogger<WeatherRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Weather> CreateWeather(WeatherDTO weather)
        {
            /*var check = await _context.weather.FindAsync(weather.City);
            
            if (!(check is null)) 
            {
               await UpdateWeatherInfo(weather);
                _logger.LogInformation($"Weather for {weather.City} in {check.Country} has been updated");
                
            }*/
            var map = _mapper.Map<Weather>(weather);
             await _context.weather.AddAsync(map);
            await _context.SaveChangesAsync();
            return map;

        }

        public async Task<bool> DeleteWeatherInfo(int Id)
        {
            var find = await _context.weather.FindAsync(Id);
            if(find is null)
            {
                return false;
            }
             _context.weather.Remove(find);
            _context.SaveChanges();
            return true;

        }

        public async Task<Weather> GetWeatherByCity(string city)
        {
            var check = await _context.weather.FindAsync(city);
            if (check is null)
            {
                _logger.LogInformation($"{city} city not Found");
            }
            return check;
        }

        public async Task<Weather> GetWeatherByCountry(string country)
        {
            var check = await _context.weather.FindAsync(country);
            if (check is null)
            {
                _logger.LogInformation($"{country} not Found");
            }
            return check;
        }

        public async Task<Weather> UpdateWeatherInfo(WeatherDTO weather, int id)
        {
            var search = await _context.weather.FindAsync(id);
            if(search is null)
            {
                _logger.LogInformation("Weather Information Unavailable");
            }
           var map =  _mapper.Map<Weather>(weather);
            await _context.weather.AddAsync(map);
            await _context.SaveChangesAsync();
            return map;

        }
    }
}
