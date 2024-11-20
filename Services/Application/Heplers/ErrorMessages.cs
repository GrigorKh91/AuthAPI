namespace Application.Heplers
{
    public sealed class ErrorMessages
    {
        // General Errors
        public const string UserNotFound = "User not found.";
        public const string InvalidEmailOrPassword = "Invalid email or password.";
        public const string RegistrationFailed = "Registration failed.";
        public const string PasswordsDoNotMatch = "Passwords do not match.";
        public const string EmailAlreadyInUse = "This email is already in use.";
        public const string UnauthorizedAccess = "Unauthorized access.";
        public const string OperationFailed = "The operation failed.";
        public const string InvalidInput = "Invalid input data.";
        public const string AccountLocked = "Your account is locked due to multiple failed login attempts.";
        public const string AccountDeactivated = "Your account has been deactivated.";

        // Email Errors
        public const string EmailConfirmationFailed = "Email confirmation failed.";
        public const string EmailNotConfirmed = "Your email address is not confirmed.";
        public const string EmailSendFailed = "Failed to send email. Please try again.";

        // Password Errors
        public const string PasswordResetFailed = "Failed to reset password.";
        public const string PasswordChangeFailed = "Failed to change password.";
        public const string PasswordTooWeak = "The provided password is too weak.";

        // OAuth Errors
        public const string OAuthLoginFailed = "OAuth login failed.";
        public const string InvalidOAuthToken = "Invalid OAuth token.";
        public const string OAuthProviderNotSupported = "OAuth provider is not supported.";

        // Validation Errors
        public const string RequiredFieldMissing = "A required field is missing.";
        public const string InvalidFieldFormat = "One or more fields have invalid formats.";
        public const string InvalidToken = "Invalid token.";
        public const string ExpiredToken = "The token has expired.";
    }
}
