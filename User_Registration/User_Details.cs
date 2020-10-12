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
        public static string REGEX_EMAIL_ID = "[a-zA-Z0-9]{3,}[.]?[a-zA-Z0-9]{0,}@[a-z]{2,}[.][a-z]{2,}[a-z]{0,}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }
        public bool ValidateEmail(string emailId)
        {
            return Regex.IsMatch(emailId, REGEX_EMAIL_ID);
        }
    }
}
