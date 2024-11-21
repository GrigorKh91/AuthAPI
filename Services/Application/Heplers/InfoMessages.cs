namespace Application.Heplers
{
    internal sealed class InfoMessages //TODO correct order
    {
        internal static string WeSentVerificationCodeToYourEmail(RandomNumberLength length) => $"We sent the {(int)length}-digit verification code to your email address";


        public const string UserAuthenticated = "User successfully authenticated.";

        public const string TokenGenerated = "Token has been successfully generated.";

        public const string UserLoggedOut = "User has been logged out.";

        public const string PasswordResetLinkSent = "Password reset link has been sent to the user's email.";

        public const string UserRegistered = "User has been successfully registered.";

        public const string TwoFactorAuthenticationEnabled = "Two-factor authentication has been enabled.";

        public const string RegistrationCodeSent = "Registration code has been sent to your email address.";

        public const string EmailVerificationLinkSent = "Email verification link has been sent to your email address.";

        public const string EmailVerified = "Email address has been successfully verified.";

        public const string EmailAlreadyVerified = "Email address is already verified.";

        public const string RegistrationSuccessful = "Registration is successful.";

        public const string AccountActivationLinkSent = "Account activation link has been sent to your email address.";

        public const string EmailPreferencesUpdated = "Your email preferences have been successfully updated.";

        public const string EmailUnsubscribeSuccessful = "You have been successfully unsubscribed from our emails.";

        public const string EmailSubscribed = "You have been successfully subscribed to our emails.";

        public const string EmailPreferencesSaved = "Your email preferences have been saved.";

        public const string EmailSettingsUpdated = "Your email settings have been successfully updated.";

        public const string EmailSentSuccessfully = "Email has been sent successfully.";

        public const string EmailTemplateSaved = "Your email template has been saved successfully.";

        public const string EmailTemplateUpdated = "Your email template has been updated successfully.";

        public const string EmailTemplateDeleted = "Your email template has been deleted successfully.";

        public const string EmailChangedSuccessfully = "Email changed successfully.";

        public const string ValidationSuccessful = "All inputs have been successfully validated.";

        public const string EmailValidated = "Email address has been successfully validated.";

        public const string PhoneNumberValidated = "Phone number has been successfully validated.";

        public const string AddressValidated = "Address has been successfully validated.";

        public const string CaptchaValidated = "Captcha has been successfully validated.";

        public const string DatabaseConnected = "Successfully connected to the database.";

        public const string RecordCreated = "Record has been successfully created.";

        public const string RecordUpdated = "Record has been successfully updated.";

        public const string RecordDeleted = "Record has been successfully deleted.";

        public const string TransactionSuccessful = "Database transaction has been successfully completed.";

        public const string DataRetrieved = "Data has been successfully retrieved.";

        public const string NetworkConnected = "Network is connected.";

        public const string NetworkStable = "Network connection is stable.";

        public const string DataSent = "Data has been successfully sent.";

        public const string DataReceived = "Data has been successfully received.";

        public const string ServerConnected = "Successfully connected to the server.";

        public const string ServerResponseReceived = "Server response has been received.";

        public const string FileUploaded = "File has been successfully uploaded.";

        public const string FileDownloaded = "File has been successfully downloaded.";

        public const string FileDeleted = "File has been successfully deleted.";

        public const string DirectoryCreated = "Directory has been successfully created.";

        public const string FileRenamed = "File has been successfully renamed.";

        public const string FileMoved = "File has been successfully moved.";

        public const string UserRoleRevoked = "Role has been successfully revoked from the user.";

        public const string UserPermissionsUpdated = "User permissions have been successfully updated.";

        public const string UserDeactivated = "User account has been successfully deactivated.";

        public const string UserReactivated = "User account has been successfully reactivated.";

        public const string UserSuspended = "User account has been successfully suspended.";

        public const string UserUnsuspended = "User account has been successfully unsuspended.";

        public const string UserPasswordChanged = "User password has been successfully changed.";

        public const string UserAccountLocked = "User account has been locked due to multiple failed login attempts.";

        public const string UserAccountUnlocked = "User account has been successfully unlocked.";

        public const string UserRoleAssignedToMultipleUsers = "Role has been assigned to multiple users successfully.";

        public const string UserAccountDeletedPermanently = "User account has been permanently deleted.";

        public const string UserAddedToGroup = "User has been successfully added to the group.";

        public const string UserRemovedFromGroup = "User has been successfully removed from the group.";

        public const string GroupCreated = "Group has been successfully created.";

        public const string GroupUpdated = "Group information has been successfully updated.";

        public const string GroupDeleted = "Group has been successfully deleted.";

        public const string GroupMembershipUpdated = "Group membership has been successfully updated.";

        public const string UserProfileViewed = "User profile has been viewed successfully.";

        public const string UserActivityLogged = "User activity has been logged successfully.";

        public const string UserSessionLogged = "User session has been logged successfully.";

        public const string AccountRegistered = "Account registered successfully.";

        public const string AccountActivationRequired = "Account activation is required. Please check your email for activation instructions.";

        public const string AccountVerified = "Your account has been successfully verified.";

        public const string AccountActivated = "Your account has been successfully activated.";

        public const string AccountProfileCreated = "Account profile has been created successfully.";

        public const string AccountSetupCompleted = "Account setup has been completed successfully.";

        public const string AccountPreferencesSaved = "Your account preferences have been saved successfully.";

        public const string AccountSettingsUpdated = "Your account settings have been updated successfully.";

        public const string AccountLinked = "Your account has been linked successfully.";

        public const string AccountUnlinked = "Your account has been unlinked successfully.";

        public const string AccountDeleted = "Your account has been deleted successfully.";

        public const string AccountSuspended = "Your account has been suspended.";

        public const string AccountRestored = "Your account has been restored.";

        public const string AccountAccessGranted = "Access to your account has been granted.";

        public const string AccountAccessRevoked = "Access to your account has been revoked.";

        public const string AccountRoleAssigned = "Role has been assigned to your account.";

        public const string AccountRoleRevoked = "Role has been revoked from your account.";

        public const string AccountPermissionsUpdated = "Account permissions have been updated.";

        public const string OperationSuccessful = "The operation has been completed successfully.";

        public const string ServiceAvailable = "The service is available.";

        public const string ResourceFound = "The resource has been found.";

        public const string RequestProcessed = "The request has been processed.";

        public const string SessionStarted = "Session has been successfully started.";

        public const string SessionEnded = "Session has been successfully ended.";

        public const string ConfigurationLoaded = "Configuration has been successfully loaded.";

        public const string SettingsSaved = "Settings have been successfully saved.";

        public const string ActionCompleted = "The action has been completed successfully.";

        public const string BillingHistoryNotFound = "No billing history was found";
        public const string InformationUpdated = "Your information has been updated.";
        public const string WeSentVerificationCodeToYourNewEmail = "We sent the 4-digit verification code to your New email address";
        public const string WeResentVerificationCodeToYourEmail = "We resent the 4-digit verification code to your email address";
        public const string YourPasswordHasBeenReset = "Your password has been reset.";
        public const string PaymentMethodDeleted = "Payment method deleted.";
        public const string PaymentMethodNotDeleted = "Payment method not deleted.";
        public const string PaymentMethodNotFound = "Payment method not found.";
        public const string PaymentMethodDefaultAssigned = "Default payment method assigned.";
        public const string PaymentMethodDefaultNotAssigned = "Default payment method not assigned.";
        public const string SecurityCodeIsValid = "Security code is valid";
        public const string SubscriptionAccountNotFound = "Stripe account not found for this customer.";
        public const string SubscriptionNotFound = "Subscription not found.";
        public const string SubscriptionNotUpdated = "Subscription not updated.";
        public const string SubscriptionPreviewNotAvailable = "Subscription preview is not available.";
        public const string SubscriptionUpdated = "Subscription updated.";
        public const string TwoFactorAuthDisabled = "Two-factor authentication removed.";
        public const string TwoFactorAuthEnabled = "Two-factor authentication installed.";
        public const string WeSentPasswordResetCodeYourEmail = "We sent a 'password reset' code to your email address";
        public const string EmailChangeFrequencyLimit = "For security purposes, the email address associated with your account can only be changed two (2) times in a twenty-four-hour (24-hour) period. Do you want to continue?";
        public const string EmailSuccessfullyChanged = "Email has changed successfully";
        public const string UserLocked = "User account has locked";
        public const string IsDefaultDeletedWarning = "The item marked as 'IsDefault' has been deleted. Please ensure another item is set as default if necessary.";
        public const string FavoriteAddedSuccessfully = "Favorite has been added successfully.";
        public const string FavoriteRemovedSuccessfully = "Favorite has been removed successfully.";
        public const string ConnectionAlreadySent = "Connection request has already been sent.";
        public const string ConnectedAlready = "You are already connected";
        public const string ConnectedSentSuccessfull = "Connection request was sent successfully.";
        public const string NotConnected = "You are not connected";
        public const string ConnectionRemovedSuccessfull = "Connection has been removed";
        public const string ConnectionRequestRemovedSuccessfull = "Request has been declined successfully.";
        public const string ConnectionRequestWithdrawnSuccessfull = "Request has been withdrawn successfully.";
        public const string ConnectionNotFound = "Connection not found";
        public const string ConnectionCanNotbeSentTwoWeeks = "Connectin can't be sent for two week.";
        public const string NoPendingConnectionRequest = "No pending connection request";
        public const string InviteSentSuccessfully = "Invite Sent Successfully";
    }
}
