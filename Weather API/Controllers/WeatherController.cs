using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Weather_API.Repositories.Interfaces;

namespace Weather_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController: ControllerBase
    {
        private readonly IWeatherRepository _weatherRepository;
        private readonly ILogger<WeatherController> _logger;
        private readonly IMapper _mapper;

        public WeatherController(IWeatherRepository weatherRepository, ILogger<WeatherController> logger, IMapper mapper)
        {
            _weatherRepository = weatherRepository;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
