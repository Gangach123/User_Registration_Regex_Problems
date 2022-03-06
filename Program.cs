using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingPassword = new Validation();
            validatingPassword.ValidatingPassword_4("Ganga123");
            validatingPassword.ValidatingPassword_4("ganga1234$");
            validatingPassword.ValidatingPassword_4("Ganga123@");
            validatingPassword.ValidatingPassword_4("Ganga12@");
        }
    }
}
