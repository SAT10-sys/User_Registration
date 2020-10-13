using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Globalization;
using User_Registration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Satantra",true)]
        [DataRow("satantra",false)]
        [DataRow("sa",false)]
        public void ValidateFirstNameShouldReturnExpectedResult(string firstName, bool expectedResult)
        {
            User_Details user_Details = new User_Details();
            bool result = user_Details.ValidateFirstName(firstName);
            Assert.AreEqual(expectedResult, result);
        }
        [DataRow("abc@gmail.com", true)]
        [DataRow("abc@gmail.co.in", true)]
        [DataRow("abc.xyz@gmail.com", true)]
        [DataRow("abc.xyz.pqr@gmail.com", true)]
        [DataRow("abc@gmail.co.in.au", false)]
        [DataRow("abc@.com", false)]
        [DataRow("abcgmail.com", false)]
        [DataRow(".abc@gmail.com", false)]
        public void ValidateEmailIDShouldReturnExpectedResult(string emailId, bool expectedResult)
        {
            User_Details user_Details = new User_Details();
            bool result = user_Details.ValidateEmail(emailId);
            Assert.AreEqual(expectedResult, result);
        }
        [DataRow("91 8250956874",true)]
        [DataRow("91 0987654567",false)]
        [DataRow("9876545623",false)]
        [DataRow("12 123456789",false)]
        public void ValidatePhoneNoShouldReturnExpectedResult(string phoneNo, bool expectedResult)
        {
            User_Details user_Details = new User_Details();
            bool result = user_Details.ValidateMobileNo(phoneNo);
            Assert.AreEqual(expectedResult, result);
        }
        [DataRow("A123#rBcf",true)]
        [DataRow("Abc",false)]
        [DataRow("abcdefgh",false)]
        [DataRow("123ert%gt",false)]
        public void ValidatePasswordShouldReturnExpectedResult(string password, bool expectedResult)
        {
            User_Details user_Details = new User_Details();
            bool result = user_Details.ValidatePassword(password);
            Assert.AreEqual(expectedResult, result);
        }
        public void ValidateMultipleEmail()
        {
            string message=null;
            User_Details user_Details = new User_Details();
            bool checkEmail1 = user_Details.ValidateEmail("abc@gmail.com");
            bool checkEmail2 = user_Details.ValidateEmail("abc-100@gmail.com");
            bool checkEmail3 = user_Details.ValidateEmail("abc@yahoo.co.in");
            if(checkEmail1==true && checkEmail2==true && checkEmail3==true)
                message="Email Validation is Successfull";
            Assert.AreEqual("Email Validation is successfull", message);
        }
        public void IfEmptyFirstNameShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = string.Empty;
                bool checkEmptyFirstName = user_Details.ValidateFirstName(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name cannot be empty", e.message);
            }
        }
        public void IfNullFirstNameShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = null;
                bool checkNullFirstName = user_Details.ValidateFirstName(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name cannot be null", e.message);
            }
        }
        public void IfEmptyLastNameShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = string.Empty;
                bool checkEmptyLastName = user_Details.ValidateLastName(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Last Name cannot be empty", e.message);
            }
        }
        public void IfNullLastNameShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = null;
                bool checkNullLastNAme = user_Details.ValidateLastName(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Last Name cannot be null", e.message);
            }
        }
        public void IfEmptyEmailShouldReturnThsiException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = string.Empty;
                bool checkEmptyEmail = user_Details.ValidateEmail(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email ID cannot be empty", e.message);
            }
        }
        public void IfNullEmailShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = null;
                bool checkNullEmail = user_Details.ValidateEmail(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email ID cannot be null", e.message);
            }
        }public void IfEmptyPhoneNoShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = string.Empty;
                bool checkEmptyPhoneNo = user_Details.ValidateMobileNo(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Phone Number cannot be empty", e.message);
            }
        }
        public void IfNullPhoneNoShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = null;
                bool checkNullPhoneNo = user_Details.ValidateMobileNo(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Phone Number cannot be null", e.message);
            }
        }
        public void IfEmptyPasswordShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = string.Empty;
                bool checkEmptyPassword = user_Details.ValidatePassword(message);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password cannot be empty", e.message);
            }
        }
        public void IfNullPassowrdShouldReturnThisException()
        {
            try
            {
                User_Details user_Details = new User_Details();
                string message = null;
                bool checkNullPassword = user_Details.ValidatePassword(message);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password cannot be null", e.message);
            }
        }
    }
}
