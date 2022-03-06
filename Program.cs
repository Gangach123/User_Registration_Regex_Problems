using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation validatingMail = new Validation();
            //lastName_Validation.ValidateLastName("Chilamakooru");
            //lastName_Validation.ValidateLastName("chilamakooru");
            validatingMail.Validating_Email("chilamakooru.gangaiiit@gmail.com");
            validatingMail.Validating_Email("Chilamakooru.gangaiiit@gmail.com");

        }
    }
}
