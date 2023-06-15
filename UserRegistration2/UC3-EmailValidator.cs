
public class EmailValidator
{
    public bool Validate(string email)
    {
        // Email should have the correct format and meet the required conditions
        return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".") && email.Length >= 5;
    }
}