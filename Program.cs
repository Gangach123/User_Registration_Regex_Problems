using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Name_Validation lastName_Validation = new Name_Validation();
            lastName_Validation.ValidateLastName("Chilamakooru");
            lastName_Validation.ValidateLastName("chilamakooru");
        }
    }
}
