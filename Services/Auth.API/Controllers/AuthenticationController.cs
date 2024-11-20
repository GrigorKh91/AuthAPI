namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService = authenticationService;


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
      
            var registerResult = await _authenticationService.RegisterAsync(model);

            if (registerResult.HasError)
            {
                return BadRequest(registerResult);
            }

            return Ok(ResponseDto.Success(null, "Registration successful. Please confirm your email."));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {

            var loginResult = await _authenticationService.LoginAsync(model);

            if (loginResult.HasError)
            {
                return Unauthorized(loginResult);
            }

            return Ok(loginResult);
        }


        [HttpPost("oauth-login")]
        public async Task<IActionResult> OAuthLogin([FromBody] OAuthLoginRequest model)
        {
            var oauthResult = await _authenticationService.OAuthLoginAsync(model);

            if (oauthResult.HasError)
            {
                return Unauthorized(oauthResult);
            }

            return Ok(oauthResult);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] LogoutRequest model)
        {
            var logoutResult = await _authenticationService.LogoutAsync(model);

            if (logoutResult.HasError)
            {
                return BadRequest(logoutResult);
            }

            return Ok(ResponseDto.Success(null, "Logout successful."));
        }
    }
}
