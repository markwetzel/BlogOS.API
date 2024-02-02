using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BlogOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            // TODO: Implement user registration
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            // TODO: Implement user login and JWT generation
            throw new NotImplementedException();
        }

        [HttpGet("user")]
        [Authorize]
        public IActionResult UserProfile()
        {
            // TODO: Return user profile information
            throw new NotImplementedException();
        }
    }
}
