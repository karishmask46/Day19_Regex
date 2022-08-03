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
        
        public static string LastName= "^[A-Z][a-z]{3,}$";

       
        public bool ValidateString(string lsName)
        {
            return Regex.IsMatch(lsName, LastName);
        }
    }
}
