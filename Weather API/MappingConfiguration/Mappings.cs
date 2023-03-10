using AutoMapper;
using Weather_API.Data;
using Weather_API.DTO;
using Weather_API.Models;

namespace Weather_API.MappingConfiguration
{
    public class Mappings: Profile
    {
        public Mappings()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Weather, WeatherDTO>().ReverseMap();
        }
    }
}
