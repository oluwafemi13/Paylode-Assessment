using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather_API.Data;
using Weather_API.DTO;

namespace Weather_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<AuthenticationController> _logger;
        private readonly UserManager<User> _userManager;

        public AuthenticationController(IMapper mapper, ILogger<AuthenticationController> logger, UserManager<User> userManager)
        {
            _mapper = mapper;
            _logger = logger;
        }

        //Register User
        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserDTO userDto)
        {
            try
            {
                var user = _mapper.Map<User>(userDto);
                var result = await _userManager.CreateAsync(user, userDto.Password);

                if (result.Succeeded is false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                        _logger.LogError($"{error.Description}");
                    }
                    return BadRequest();
                }
                //crosscheck before submitting
                await _userManager.AddToRoleAsync(user, $"{userDto.Role}");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"something went wrong in the {nameof(Register)}");
                return Problem($"something went wrone in the {nameof(Register)}",statusCode: 500);
                //throw;
            }
        }
        //,\login user
        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginUserDTO login)
        {
            _logger.LogInformation($"User attempt to login with {nameof(login.Email)} ");
            try
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                var verifyPassword = await _userManager.CheckPasswordAsync(user, login.Password);
                if(user is null || verifyPassword is false)
                {
                    _logger.LogInformation("Wrong Email or Password");
                    return NotFound();
                }
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"something went wrong in the {nameof(login)}");
                return Problem($"something went wrone in the {nameof(login)}", statusCode: 500);
            }
            
        }
    }
}
