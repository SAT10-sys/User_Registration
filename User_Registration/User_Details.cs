using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class User_Details
    {
        public string REGEX_FIRST_NAME = "^[A-Z]{1,}[A-Za-z]{2,}$";
        public string REGEX_LAST_NAME = "^[A-Z]{1,}[A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }
    }
}
