namespace Domain.ViewModels.Authentication
{
    public class ApiRegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
