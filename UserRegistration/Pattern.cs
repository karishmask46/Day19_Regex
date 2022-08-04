using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
     class Patterns
    {

        public static string Regex_Email = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";

        public bool ValidateString(string email)
        {
            return Regex.IsMatch(email,Regex_Email);
        }
    }
}
