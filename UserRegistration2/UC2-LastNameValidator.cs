public class LastNameValidator
{
    public bool Validate(string lastName)
    {
        // Last name starts with a capital letter and has a minimum length of 3 characters
        return !string.IsNullOrEmpty(lastName) && char.IsUpper(lastName[0]) && lastName.Length >= 3;
    }
}