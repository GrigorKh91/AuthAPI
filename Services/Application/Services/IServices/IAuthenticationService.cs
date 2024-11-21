namespace Application.Services.IServices
{
    public interface IApiAuthenticationService
    {
        Task<ResponseDto> RegisterAsync(ApiRegisterRequest registerRequest);
        Task<ResponseDto> LoginAsync(LoginRequest  loginRequest);
        Task<ResponseDto> OAuthLoginAsync(OAuthLoginRequest  oAuthLoginRequest);
        Task<ResponseDto> LogoutAsync();
    }
}
