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

        public static string Regex_PassWord2 = "^[A-Z][a-z0-9]{7,}$";

        public bool ValidateString(string password)
        {
            return Regex.IsMatch(password,Regex_PassWord2);
        }
    }
}
