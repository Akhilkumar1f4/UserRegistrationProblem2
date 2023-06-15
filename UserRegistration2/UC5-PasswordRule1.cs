public class PasswordValidator
{
    public bool Validate(string password)
    {
        // Password should have a minimum of 8 characters
        return !string.IsNullOrEmpty(password) && password.Length >= 8;
    }
}
