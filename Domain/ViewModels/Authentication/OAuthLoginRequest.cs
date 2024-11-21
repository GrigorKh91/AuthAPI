namespace Domain.ViewModels.Authentication
{
    public class OAuthLoginRequest
    {
        public string Email { get; set; }
        public string Provider { get; set; } // e.g., Google, Facebook
        public string Token { get; set; }   // OAuth provider's access token
    }
}
