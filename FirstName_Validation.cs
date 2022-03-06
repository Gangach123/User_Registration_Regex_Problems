using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Validation
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string emailId = "^[a-z]{3,}([.]{1}[a-z]{2,})?[/@/][a-z]{2,5}[/./][a-z]{2,5}([.]{1}[a-z]{2})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^[a-zA-Z0-9]{8,}";
        public static string password_2 = @"^(?=.*[A-Z])[[a-zA-Z1-9]{1}][[a-zA-Z0-9]{7,}]";
        public static string password_3 = @"^(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public static string password_4 = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        public static string mail = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public void Validate(string data)
        {
            string result = Regex.IsMatch(data, mail) ? $"{data}: valid" : $"{data}: invalid";

            Console.WriteLine(result);
        }
        public void ValidatingPassword_4(string data)
        {
            string result = Regex.IsMatch(data, password_4) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword_3(string data)
        {
            string result = Regex.IsMatch(data, password_3) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword_2(string data)
        {
            string result = Regex.IsMatch(data, password_2) ? $"{data}: Valid Password" : $"{data}: InValid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword(string data)
        {
            string result = Regex.IsMatch(data, password) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public void ValidatingNumber(string data)
        {
            string result = Regex.IsMatch(data, mobileNo) ? $"{data}: Valid Mobile Number" : $"{data}: Invalid Mobile Number";

            Console.WriteLine(result);
        }
        public void Validating_Email(string data)
        {
            string result = Regex.IsMatch(data, emailId) ? $"{data}: Valid Mail Id" : $"{data}: Invalid Mail Id";

            Console.WriteLine(result);
        }


        public void ValidateFirstName(string data)
        {

            string result = Regex.IsMatch(data, firstName) ? $"{data}: valid" : $"{data}: invalid";

            Console.WriteLine(result);


        }
        public void ValidateLastName(string data)
        {

            string result = Regex.IsMatch(data, lastName) ? $"{data}: valid" : $"{data}: invalid";

            Console.WriteLine(result);


        }
    }
}
