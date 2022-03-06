using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation clearingMail = new Validation();
            clearingMail.Validate("abc@yahoo.com");
            clearingMail.Validate("abc-100@yahoo.com");
            clearingMail.Validate("abc111@abc.com");
            clearingMail.Validate("abc-100@abc.net");
            clearingMail.Validate("abc.100@abc.com.au");
            clearingMail.Validate("abc@1.com");
            clearingMail.Validate("abc@gmail.com.com");
            clearingMail.Validate("abc+100@gmail.com");

            clearingMail.Validate("abc@.com.com");
            clearingMail.Validate("...abc@abc.com");
            clearingMail.Validate("abc@abc@gmail.@com");
            clearingMail.Validate("abc..2002@gmail...com");
            clearingMail.Validate("abc@gmail.com@.1a");
            clearingMail.Validate("abc@gmail.com.aa.au");

        }
    }
}
