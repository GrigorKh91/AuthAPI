using Application.Services.IServices;
using Domain.ViewModels.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticationController(IApiAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IApiAuthenticationService _authenticationService = authenticationService;

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] ApiRegisterRequest  request)
        {
      
            var registerResult = await _authenticationService.RegisterAsync(request);

            if (registerResult.HasError)
            {
                return BadRequest(registerResult);
            }

            return Ok(ResponseDto.Success(null, "Registration successful. Please confirm your email."));
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] LoginRequest model)
        //{

        //    var loginResult = await _authenticationService.LoginAsync(model);

        //    if (loginResult.HasError)
        //    {
        //        return Unauthorized(loginResult);
        //    }

        //    return Ok(loginResult);
        //}


        //[HttpPost("oauth-login")]
        //public async Task<IActionResult> OAuthLogin([FromBody] OAuthLoginRequest model)
        //{
        //    var oauthResult = await _authenticationService.OAuthLoginAsync(model);

        //    if (oauthResult.HasError)
        //    {
        //        return Unauthorized(oauthResult);
        //    }

        //    return Ok(oauthResult);
        //}

        //[HttpPost("logout")]
        //public async Task<IActionResult> Logout([FromBody] LogoutRequest model)
        //{
        //    var logoutResult = await _authenticationService.LogoutAsync(model);

        //    if (logoutResult.HasError)
        //    {
        //        return BadRequest(logoutResult);
        //    }

        //    return Ok(ResponseDto.Success(null, "Logout successful."));
        //}
    }
}
