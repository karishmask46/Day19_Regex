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

        public static string Regex_PassWord3 = "^[A-Z]{1,}[0-9]{1,}[A-Za-z]{8,}";
        public bool ValidateString(string password)
        {
            return Regex.IsMatch(password,Regex_PassWord3);
        }
    }
}
