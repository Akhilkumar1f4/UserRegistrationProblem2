public class UserRegistrationProgram
{
    private static bool ValidateFirstName(string firstName)
    {
        FirstNameValidator validator = new FirstNameValidator();
        return validator.Validate(firstName);
    }

    private static bool ValidateLastName(string lastName)
    {
        LastNameValidator validator = new LastNameValidator();
        return validator.Validate(lastName);
    }

    private static bool ValidateEmail(string email)
    {
        EmailValidator validator = new EmailValidator();
        return validator.Validate(email);
    }

    private static bool ValidateMobileFormat(string mobileNumber)
    {
        MobileFormatValidator validator = new MobileFormatValidator();
        return validator.Validate(mobileNumber);
    }

    private static bool ValidatePassword(string password)
    {
        List<Func<string, bool>> passwordRules = new List<Func<string, bool>>()
        {
            (new PasswordValidator()).Validate,
            (new PasswordUpperCaseRule()).Validate,
            (new PasswordNumericRule()).Validate,
            (new PasswordSpecialCharacterRule()).Validate
        };

        foreach (var rule in passwordRules)
        {
            if (!rule(password))
                return false;
        }

        return true;
    }

    private static void ClearEmailSamples(List<string> emailSamples)
    {
        EmailSamplesClearer clearer = new EmailSamplesClearer();
        clearer.ClearEmailSamples(emailSamples);
    }
}