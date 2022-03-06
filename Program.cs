using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            FirstName_Validation firstName_Validation = new FirstName_Validation();
            firstName_Validation.ValidateFirstName("Ganga");
            firstName_Validation.ValidateFirstName("ganga");
        }
    }
}
