public class MobileFormatValidator
{
    public bool Validate(string mobileNumber)
    {
        // Mobile number should follow the predefined format
        return !string.IsNullOrEmpty(mobileNumber) && mobileNumber.Length == 12 && mobileNumber.StartsWith("91 ");
    }
}