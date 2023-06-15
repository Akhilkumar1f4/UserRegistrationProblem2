public class PasswordNumericRule
{
    public bool Validate(string password)
    {
        // Password should have at least 1 numeric digit
        foreach (char c in password)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }
}

