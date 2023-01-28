using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
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
            var weather = new Weather();

            var searched = _context.weather.Where(s => s.City == city);
            if (searched is null)
            {
                _logger.LogInformation($"{city} not Found");
            }
            //execute query
            foreach (var search in searched)
            {
                weather.Id = search.Id;
                weather.TemperatureCelcius = search.TemperatureCelcius;
                weather.Date = search.Date;
                weather.City = search.City;
                weather.Country = search.Country;
                weather.CloudFormation = search.CloudFormation;
                weather.Description = search.Description;

            }

            return weather;
        }

        public async Task<IEnumerable<Weather>> GetWeatherByCountry(string country)
        {
            

        var searched =await _context.weather.Where(s => s.Country == country).ToListAsync();
            if (searched is null)
            {
                _logger.LogInformation($"{country} not Found");
            }
            
            var map = _mapper.Map<IEnumerable<Weather>>(searched);

            return map;
        }

        public async Task<Weather> UpdateWeatherInfo(WeatherDTO weather, int id)
        {
            
            var search = await _context.weather.FindAsync(id);
            if(search is null)
            {
                _logger.LogInformation("Weather Information Unavailable");
            }

            var map = _mapper.Map(weather, search);
            _context.weather.Update(map);

                await _context.SaveChangesAsync();

            return map;
        }
    }
}
