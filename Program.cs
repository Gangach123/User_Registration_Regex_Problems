using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingNumber = new Validation();
            validatingNumber.ValidatingNumber("91 7702173235");
            validatingNumber.ValidatingNumber("12 7702173235");
        }
    }
}
