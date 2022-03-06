using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingPassword = new Validation();
            validatingPassword.ValidatingPassword_2("Ganga123");
            validatingPassword.ValidatingPassword_2("ganga12");
            validatingPassword.ValidatingPassword_2("GangaA234");
            validatingPassword.ValidatingPassword_2("Ganga1");
        }
    }
}
