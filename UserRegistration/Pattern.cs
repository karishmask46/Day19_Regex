﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
     class Patterns
    {

        public static string Regex_PassWord4 = "^[A-Za-z]{8,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$";
        public bool ValidateString(string password)
        {
            return Regex.IsMatch(password,Regex_PassWord4);
        }
    }
}
