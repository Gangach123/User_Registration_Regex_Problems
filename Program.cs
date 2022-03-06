using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingPassword = new Validation();
            validatingPassword.ValidatingPassword("Ganga123");
            validatingPassword.ValidatingPassword("Ganga12");
            validatingPassword.ValidatingPassword("Ganga1234");
            validatingPassword.ValidatingPassword("Ganga1");
        }
    }
}
