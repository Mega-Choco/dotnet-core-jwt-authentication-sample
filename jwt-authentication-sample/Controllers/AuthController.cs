using jwt_authentication_sample.Models.Request;
using jwt_authentication_sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace jwt_authentication_sample.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [HttpPost("join")]
        public async Task<IActionResult> Join([FromBody] JoinRequest model)
        {
            var result =await _authService.JoinAsync(model);    
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
