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
