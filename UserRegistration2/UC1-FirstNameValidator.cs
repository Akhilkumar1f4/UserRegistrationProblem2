using System;
using System.Collections.Generic;

public class FirstNameValidator
{
    public bool Validate(string firstName)
    {
        // First name starts with a capital letter and has a minimum length of 3 characters
        return !string.IsNullOrEmpty(firstName) && char.IsUpper(firstName[0]) && firstName.Length >= 3;
    }
}