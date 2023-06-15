public class PasswordSpecialCharacterRule
{
    public bool Validate(string password)
    {
        // Password should have exactly 1 special character
        int specialCharacterCount = 0;
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                specialCharacterCount++;
            }
        }
        return specialCharacterCount == 1;
    }
}