namespace Domain.ViewModels.Authentication
{
    public class ValidateAccountRequest
    {
        public int UserId { get; set; }
        public string OneTimeRegisterationCode { get; set; }
    }
}
