using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
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
        private readonly IConfiguration _configuration;

        public AuthenticationController(IMapper mapper,
                                        ILogger<AuthenticationController> logger, 
                                        UserManager<User> userManager,
                                        IConfiguration configuration)
        {
            _mapper = mapper;
            _logger = logger;
            _userManager = userManager;
            _configuration = configuration;
        }

        //Register User
        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserDTO userDto)
        {
            try
            {
                var user = _mapper.Map<User>(userDto);
                user.UserName = userDto.Email;
                var result = await _userManager.CreateAsync(user, userDto.Password);

                if (result.Succeeded == false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                        _logger.LogError($"{error.Description}");
                    }
                    return BadRequest(ModelState);
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
        public async Task<ActionResult<AuthenticationResponse>> Login(LoginUserDTO login)
        {
            _logger.LogInformation($"User attempt to login with {nameof(login.Email)} ");
            try
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                var verifyPassword = await _userManager.CheckPasswordAsync(user, login.Password);

                if(user is null || verifyPassword is false)
                {
                    _logger.LogInformation("Wrong Email or Password");
                    return Unauthorized();
                }

                string tokenString = await GenerateNewToken(user);

                var response = new AuthenticationResponse
                {
                    userId = user.Id,
                    Token = tokenString,
                    Email = user.Email
                };
                return Ok(response);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"something went wrong in the {nameof(login)}");
                return Problem($"something went wrone in the {nameof(login)}", statusCode: 500);
            }
            
        }

        private async Task<string> GenerateNewToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(e => new Claim(ClaimTypes.Role, e)).ToList();
            var userClaim = await _userManager.GetClaimsAsync(user);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("Uid", user.Id)


            }.Union(userClaim)
            .Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(Convert.ToInt32(_configuration["JwtSettings:Duration"])),
                signingCredentials:credentials


                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
