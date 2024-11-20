using Domain.ViewModels.Response;

namespace Application.Services.IServices
{
    public interface IApiAuthenticationService
    {
        Task<ResponseDto> RegisterAsync(Domain.ViewModels.Authentication.RegisterRequest request);
        Task<ResponseDto> LoginAsync(LoginRequest request);
        Task<ResponseDto> OAuthLoginAsync(OAuthLoginRequest request);
        Task<ResponseDto> LogoutAsync(LogoutRequest request);
    }
}
