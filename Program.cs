using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingPassword_2 = new Validation();
            validatingPassword_2.ValidatingPassword_2("Ganga@7702");
            validatingPassword_2.ValidatingPassword_2("Ganga123");
            validatingPassword_2.ValidatingPassword_2("Ganga12!");
            validatingPassword_2.ValidatingPassword_2("Ganga789&");
            validatingPassword_2.ValidatingPassword_2("Ganga@12");
        }
    }
}
