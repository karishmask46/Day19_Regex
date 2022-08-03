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
        public static string RegexName = "^[A-Z][a-z]{3,}$";

        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexName);
        }
    }
}
