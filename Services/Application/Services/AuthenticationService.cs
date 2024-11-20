using Application.Heplers;
using Domain.ViewModels.Response;
using Microsoft.AspNetCore.Identity;

namespace Application.Services
{
    public class ApiAuthenticationService(UserManager<User> userManager, SignInManager<User> signInManager, IJwtService jwtService) : IApiAuthenticationService
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;
        private readonly IJwtService _jwtService = jwtService;

        public async Task<ResponseDto> RegisterAsync(Domain.ViewModels.Authentication.RegisterRequest request)
        {
            if (request.Password != request.ConfirmPassword)
            {
                return ResponseDto.Error(ErrorMessages.PasswordsDoNotMatch);
            }

            var user = new User { UserName = request.Email, Email = request.Email };
            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                return ResponseDto.Error("Registration failed.", result.Errors.Select(e => e.Description));
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            // TODO: Send confirmation email with the token

            return ResponseDto.Success(null, "User registered successfully.");
        }

        public async Task<ResponseDto> LoginAsync(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return ResponseDto.Error("Invalid email or password.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, true, false);

            if (!result.Succeeded)
            {
                return ResponseDto.Error("Invalid email or password.");
            }

            var token = _jwtService.GenerateToken(user);
            return ResponseDto.Success(token, "Login successful.");
        }

        public async Task<ResponseDto> OAuthLoginAsync(OAuthLoginRequest request)
        {
            // TODO: Validate the OAuth token and retrieve user info
            // Example: Validate Google/Facebook token

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return ResponseDto.Error("User not found.");
            }

            var token = _jwtService.GenerateToken(user);
            return ResponseDto.Success(token, "OAuth login successful.");
        }

        public async Task<ResponseDto> LogoutAsync(LogoutRequest request)
        {
            await _signInManager.SignOutAsync();
            return ResponseDto.Success(null, "Logout successful.");
        }
    }
}
