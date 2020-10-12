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
        public string REGEX_EMAIL_ID = "[a-zA-Z0-9]{3,}[.]?[a-zA-Z0-9]{0,}@[a-z]{2,}[.][a-z]{2,}[a-z]{0,}";
        public string REGEX_MOBILE_NO = "^[1-9]{2} [1-9]{1}[0-9]{9}$";
        public string REGEX_PASSWORD1 = "[a-zA-Z0-9]{8}";
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
        public bool ValidateMobileNo(string phoneNo)
        {
            return Regex.IsMatch(phoneNo, REGEX_MOBILE_NO);
        }
        public bool ValidatePasswordRule1(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD1);
        }
    }
}
