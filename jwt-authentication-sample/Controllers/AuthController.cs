using jwt_authentication_sample.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace jwt_authentication_sample.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        
        [HttpPost("join")]
        public async Task<IActionResult> Join([FromBody] JoinRequest model)
        {
            if (TryValidateModel(model))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
