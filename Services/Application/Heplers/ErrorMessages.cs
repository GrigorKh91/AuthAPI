namespace Application.Heplers
{
    public sealed class ErrorMessages  //TODO correct order
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






        public const string WrongCredentials = "Invalid email or password.";


        public const string UserInfoEndpointNotConfigured = "User info endpoint is not configured.";

        public const string UserNotAuthenticated = "User is not authenticated.";

        public const string AccessDenied = "Access denied.";

        public const string InvalidCredentials = "Invalid username or password.";

        public const string UserLockedOut = "User account is locked out.";


        public const string TokenExpired = "Token has expired.";

        public const string TokenNotProvided = "Token was not provided.";

        public const string InvalidRefreshToken = "Invalid refresh token.";

        public const string PasswordExpired = "Password has expired.";

        public const string InvalidPassword = "Invalid password.";

        public const string AccountDisabled = "User account is disabled.";

        public const string InvalidCaptcha = "Invalid CAPTCHA.";

        public const string TwoFactorAuthenticationFailed = "Two-factor authentication failed.";

        public const string PasswordChangeRequired = "Password change is required.";


        public const string InvalidOtp = "Invalid one-time password (OTP).";

        public const string OtpExpired = "One-time password (OTP) has expired.";

        public const string TooManyFailedAttempts = "Too many failed login attempts. Please try again later.";

        public const string LoginTemporarilyDisabled = "Login temporarily disabled due to suspicious activity.";

        public const string AccountLockedForSecurity = "Account locked for security reasons. Please contact support.";

        public const string AccountNotActive = "User account is not active.";

        public const string UnverifiedDevice = "Unverified device. Please verify your device to continue.";

        public const string AuthenticationMethodNotSupported = "Authentication method not supported.";

        public const string SsoAuthenticationFailed = "Single Sign-On (SSO) authentication failed.";

        public const string ExternalProviderError = "Error with external authentication provider.";

        public const string InvalidAuthCode = "Invalid authentication code.";

        public const string AuthCodeExpired = "Authentication code has expired.";

        public const string DeviceSessionExpired = "Device session has expired.";

        public const string PasswordRequired = "Password is required.";

        public const string InvalidCode = "Invalide Code.";


        public const string ForbiddenAccess = "Forbidden access.";

        public const string InsufficientPermissions = "Insufficient permissions.";

        public const string PleaseEnterValidEmail = "Please enter a valid email.";

        public const string RequiredField = "This field is required.";

        public const string InvalidEmailFormat = "Invalid email format.";

        public const string StringTooShort = "The string is too short.";

        public const string StringTooLong = "The string is too long.";

        public const string InvalidCharacters = "The field contains invalid characters.";

        public const string ValueOutOfRange = "The value is out of the allowable range.";

        public const string InvalidDateFormat = "Invalid date format.";

        public const string DateOutOfRange = "The date is out of the allowable range.";

        public const string InvalidPhoneNumber = "Invalid phone number format.";


        public const string PasswordTooShort = "The password is too short.";

        public const string PasswordTooLong = "The password is too long.";


        public const string UsernameTaken = "The username is already taken.";

        public const string InvalidUrl = "Invalid URL format.";

        public const string InvalidPostalCode = "Invalid postal code.";

        public const string AgeRequirementNotMet = "You do not meet the minimum age requirement.";

        public const string InvalidCreditCardNumber = "Invalid credit card number.";

        public const string InvalidCvv = "Invalid CVV code.";

        public const string InvalidExpirationDate = "Invalid expiration date.";

        public const string InvalidIpAddress = "Invalid IP address format.";

        public const string FileTooLarge = "The file size exceeds the allowable limit.";

        public const string MinValueNotMet = "The value does not meet the minimum requirement.";

        public const string MaxValueExceeded = "The value exceeds the maximum limit.";

        public const string InvalidBooleanValue = "Invalid boolean value.";

        public const string InvalidEnumValue = "Invalid enumeration value.";

        public const string InvalidJsonFormat = "Invalid JSON format.";

        public const string InvalidXmlFormat = "Invalid XML format.";

        public const string DuplicateEntry = "Duplicate entry is not allowed.";

        public const string InvalidSelection = "Invalid selection.";

        public const string TermsNotAccepted = "You must accept the terms and conditions.";

        public const string DataNotFound = "Requested data not found.";

        public const string DataSaveError = "Error occurred while saving data.";

        public const string DataUpdateError = "Error occurred while updating data.";

        public const string DataDeleteError = "Error occurred while deleting data.";

        public const string DataConflict = "Data conflict occurred.";

        public const string DataIntegrityViolation = "Data integrity violation.";

        public const string DatabaseConnectionError = "Unable to connect to the database.";

        public const string QueryExecutionError = "Error occurred during query execution.";

        public const string TransactionFailed = "Transaction failed.";

        public const string FileNotFound = "File not found.";

        public const string FileUploadError = "Error occurred while uploading the file.";

        public const string FileSizeExceeded = "File size exceeded the limit.";

        public const string InvalidFileType = "Invalid file type.";

        public const string FileReadError = "Error occurred while reading the file.";

        public const string FileWriteError = "Error occurred while writing to the file.";

        public const string FileAccessDenied = "Access to file denied.";

        public const string NetworkUnavailable = "Network is unavailable.";

        public const string TimeoutError = "Request timed out.";

        public const string ServiceUnavailable = "Service is temporarily unavailable.";

        public const string ExternalServiceError = "Error occurred while accessing external service.";

        public const string DNSLookupFailed = "DNS lookup failed.";

        public const string ConnectionRefused = "Connection refused by the server.";

        public const string ConnectionReset = "Connection was reset.";

        public const string ApiRateLimitExceeded = "API rate limit exceeded.";

        public const string InvalidApiResponse = "Invalid API response.";

        public const string ApiNotFound = "API endpoint not found.";

        public const string ApiUnauthorized = "Unauthorized API access.";

        public const string ApiForbidden = "Forbidden API access.";

        public const string ConfigurationMissing = "Configuration is missing.";

        public const string InvalidConfiguration = "Invalid configuration.";

        public const string ConfigurationLoadError = "Error occurred while loading configuration.";

        public const string SessionExpired = "Session has expired.";

        public const string SessionNotFound = "Session not found.";

        public const string SessionCreationError = "Error occurred while creating session.";

        public const string SessionTerminationError = "Error occurred while terminating session.";

        public const string PaymentFailed = "Payment processing failed.";

        public const string InvalidPaymentDetails = "Invalid payment details.";

        public const string PaymentMethodNotSupported = "Payment method not supported.";

        public const string InsufficientFunds = "Insufficient funds.";

        public const string PaymentGatewayError = "Error occurred with the payment gateway.";

        public const string UnknownError = "An unknown error occurred.";


        public const string InvalidOperation = "Invalid operation.";

        public const string UnauthorizedOperation = "Unauthorized operation.";

        public const string BadRequest = "Bad request.";

        public const string NotFound = "Resource not found.";

        public const string Conflict = "Conflict occurred.";

        public const string InternalServerError = "Internal server error.";

        public const string NotImplemented = "Functionality not implemented.";

        public const string MaintenanceMode = "Service is under maintenance.";

        public const string ResourceLimitExceeded = "Resource limit exceeded.";

        public const string DependencyFailure = "A dependent service or operation failed.";

        public const string LogFileCreationFailed = "Failed to create log file.";

        public const string LogWriteError = "Error occurred while writing to log.";

        public const string LogConfigurationError = "Log configuration error.";

        public const string UserAlreadyExists = "User already exists.";

        public const string UserCreationFailed = "Failed to create user.";

        public const string UserUpdateFailed = "Failed to update user.";

        public const string UserDeletionFailed = "Failed to delete user.";

        public const string InvalidUserRole = "Invalid user role.";

        public const string InvalidUserStatus = "Invalid user status.";

        public const string EmailRequired = "Email is required.";


        public const string InvalidEmailAddress = "Invalid email address or password.";


        public const string EmailAlreadyAssociated = "Email is already associated with an account.";

        public const string PageNotFound = "The requested page could not be found.";

        public const string ActionNotAllowed = "This action is not allowed.";

        public const string FeatureNotAvailable = "This feature is not available.";

        public const string OperationTimeout = "The operation timed out.";

        public const string UnsupportedOperation = "This operation is not supported.";

    }
}
