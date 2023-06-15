 class Program
{
    public static void Main(string[] args)
    {
            // User registration process

            Console.WriteLine("User Registration");
            Console.WriteLine("-----------------");
        
        string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Mobile Number: ");
            string mobileNumber = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Validate user inputs
            bool isFirstNameValid = ValidateFirstName(firstName);
            bool isLastNameValid = ValidateLastName(lastName);
            bool isEmailValid = ValidateEmail(email);
            bool isMobileFormatValid = ValidateMobileFormat(mobileNumber);
            bool isPasswordValid = ValidatePassword(password);

            // Output validation results
            Console.WriteLine();
            Console.WriteLine("Validation Results");
            Console.WriteLine("------------------");
            Console.WriteLine("First Name: " + (isFirstNameValid ? "Valid" : "Invalid"));
            Console.WriteLine("Last Name: " + (isLastNameValid ? "Valid" : "Invalid"));
            Console.WriteLine("Email: " + (isEmailValid ? "Valid" : "Invalid"));
            Console.WriteLine("Mobile Number: " + (isMobileFormatValid ? "Valid" : "Invalid"));
            Console.WriteLine("Password: " + (isPasswordValid ? "Valid" : "Invalid"));

            Console.ReadLine();
        }

        static bool ValidateFirstName(string firstName)
        {
            FirstNameValidator validator = new FirstNameValidator();
            return validator.Validate(firstName);
        }

        static bool ValidateLastName(string lastName)
        {
            LastNameValidator validator = new LastNameValidator();
            return validator.Validate(lastName);
        }
        static bool ValidateEmail(string email)
        {
            EmailValidator validator = new EmailValidator();
            return validator.Validate(email);
        }

        static bool ValidateMobileFormat(string mobileNumber)
        {
            MobileFormatValidator validator = new MobileFormatValidator();
            return validator.Validate(mobileNumber);
        }

        static bool ValidatePassword(string password)
        {
            PasswordValidator validator = new PasswordValidator();
            return validator.Validate(password);
        }
    }
