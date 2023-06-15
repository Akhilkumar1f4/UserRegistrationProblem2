public class PasswordUpperCaseRule
{
    public bool Validate(string password)
    {
        // Password should have at least 1 uppercase letter
        foreach (char c in password)
        {
            if (char.IsUpper(c))
                return true;
        }
        return false;
    }
}
