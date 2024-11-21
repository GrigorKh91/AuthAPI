namespace Application.Services
{
    public class ApiAuthenticationService(UserManager<User> userManager,
                                                                    SignInManager<User> signInManager,
                                                                    UserManagerHelper userManagerHelper,
                                                                    IJwtService jwtService,
                                                                    IMapper mapper,
                                                                    IConfiguration configuration) : IApiAuthenticationService
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;
        private readonly UserManagerHelper _userManagerHelper = userManagerHelper;
        private readonly IJwtService _jwtService = jwtService;
        private readonly IMapper _mapper = mapper;
        private readonly IConfiguration _configuration = configuration;

        public async Task<ResponseDto> RegisterAsync(ApiRegisterRequest registerRequest)
        {
            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                return ResponseDto.Error(ErrorMessages.PasswordsDoNotMatch);
            }

            var user = await _userManagerHelper.FindUserAsync(registerRequest.Email);
            if (user != null)
            {
                return ResponseDto.Error(ErrorMessages.EmailAlreadyInUse);
            }

            user = _mapper.Map<User>(registerRequest);
            user.CreatedDate = DateTime.UtcNow;
            user.UserName = Guid.NewGuid().ToString();
            user.OneTimeRegistrationCode = RandomNumber(RandomNumberLength.FourDigits);
            user.OneTimeRegistrationDate = DateTime.UtcNow;

            var result = await _userManager.CreateAsync(user, registerRequest.Password);
            if (!result.Succeeded)
            {
                return ResponseDto.Error(ErrorMessages.UserCreationFailed, result.Errors.Select(e => e.Description));
            }

            // TODO: Send confirmation email with the OneTimeRegistrationCode

            return ResponseDto.Success(message: InfoMessages.WeSentVerificationCodeToYourEmail(RandomNumberLength.FourDigits));
        }

        //public async Task<ResponseDto> ValidateAccountAsync(ValidateAccountRequest confirmEmailData)
        //{
        //    var user = await _userManager.FindByIdAsync(confirmEmailData.Id);
        //    if (user != null && !user.DeletedDate.HasValue && !user.Inactive)
        //    {
        //        // check  token and expiration time
        //        if (!user.OneTimeRegistrationDate.HasValue)
        //        {
        //            _response.HasError = true;
        //            _response.Message = "Code expired. Resend a new code.";
        //            return _response;
        //        }
        //        if (int.TryParse(_configuration["RegistrationExpiresInMinutes"], out int registrationExpiresInMinutes))
        //        {
        //            if ((DateTime.UtcNow - user.OneTimeRegistrationDate.Value).TotalMinutes > registrationExpiresInMinutes)
        //            {
        //                _response.HasError = true;
        //                _response.Message = "Code expired. Resend a new code.";
        //                return _response;

        //            };
        //            if (user.OneTimeRegistrationCode != confirmEmailData.OneTimeRegisterationCode)
        //            {
        //                _response.HasError = true;
        //                _response.Message = "Invalid verification code";
        //                return _response;
        //            }
        //            user.EmailConfirmed = true;
        //            user.OneTimeRegistrationCode = null;
        //            user.OneTimeRegistrationDate = null;

        //            if (!string.IsNullOrEmpty(user.ReferredBy))
        //            {
        //                await SatAsConnectionToReferredByAsync(user.ReferredBy, user.Id);
        //            }
        //            await UserManager.UpdateAsync(user);

        //            _response.Model = _mapper.Map<UserItem>(user);
        //            return _response;
        //        }
        //        _response.HasError = true;
        //        _response.Message = "Code expired. Resend a new code.";
        //        return _response;
        //    }
        //    _response.HasError = true;
        //    _response.Message = "Code expired. Resend a new code.";
        //    return _response;
        //}


















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

        public async Task<ResponseDto> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return ResponseDto.Success(null, "Logout successful.");
        }












    }
}
