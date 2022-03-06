using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingPassword = new Validation();
            validatingPassword.ValidatingPassword_3("Ganga123");
            validatingPassword.ValidatingPassword_3("ganga123");
            validatingPassword.ValidatingPassword_3("GangaABCD");
            validatingPassword.ValidatingPassword_3("Gangadevi");
        }
    }
}
