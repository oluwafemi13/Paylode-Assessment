using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Weather_API.DTO;
using Weather_API.Models;
using Weather_API.Repositories.Interfaces;

namespace Weather_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController: ControllerBase
    {
        private readonly IWeatherRepository _weatherRepository;
        private readonly ILogger<WeatherController> _logger;
        

        public WeatherController(IWeatherRepository weatherRepository, ILogger<WeatherController> logger)
        {
            _weatherRepository = weatherRepository;
            _logger = logger;
           
        }

        [HttpGet("GetByCountry")]
        public async Task<ActionResult<Weather>> GetByCOuntry(string country) 
        {
            var result = await _weatherRepository.GetWeatherByCountry(country);
            return Ok(result);
        }

        [HttpGet("GetByCity")]
        public async Task<ActionResult<Weather>> GetByCity(string city)
        {
            var result = await _weatherRepository.GetWeatherByCity(city);
            return Ok(result);
        }

        [HttpPost("CreateWeather")]
        public async Task<ActionResult> CreateWeather([FromBody] WeatherDTO weather)
        {
            var create = await _weatherRepository.CreateWeather(weather);
            return Ok(create);
        }

        [HttpPut("UpdateWeather")]
        public async Task<ActionResult> UpdateWeather([FromBody] WeatherDTO weather)
        {
            var create = await _weatherRepository.UpdateWeatherInfo(weather);
            return Ok(create);
        }



    }
}
