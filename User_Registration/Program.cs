using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to User Registration Problem ");
            User_Details userDetails = new User_Details();
            RegStart1:
            Console.WriteLine("Enter first name(starting with capitals and minimum three letters) ");
            string firstName = Console.ReadLine();
            bool checkFirstName = userDetails.ValidateFirstName(firstName);
            if(checkFirstName==true)
                Console.WriteLine(" FIRST NAME: "+firstName);
            else
            {
                Console.WriteLine("Please enter valid first name");
                goto RegStart1;
            }
        RegStart2:
            Console.WriteLine("Enter last name(starting with capitals and minimum three letters) ");
            string lastName = Console.ReadLine();
            bool checkLastName = userDetails.ValidateLastName(lastName);
            if (checkLastName == true)
                Console.WriteLine(" LAST NAME: " + lastName);
            else
            {
                Console.WriteLine(" Please enter valid last name ");
                goto RegStart2;
            }
        RegStart3:
            Console.WriteLine("Enter Email Id");
            string emailId = Console.ReadLine();
            bool checkEmailId = userDetails.ValidateEmail(emailId);
            if (checkEmailId == true)
                Console.WriteLine(" EMAIL ID: " + emailId);
            else
            {
                Console.WriteLine(" Please enter valid Email Id ");
                goto RegStart3;
            }
        RegStart4:
            Console.WriteLine("Enter mobile number(with country code followed by space)");
            string phoneNo = Console.ReadLine();
            bool checkPhoneNo = userDetails.ValidateMobileNo(phoneNo);
            if (checkPhoneNo == true)
                Console.WriteLine(" MOBILE NUMBER: " + phoneNo);
            else
            {
                Console.WriteLine(" Please enter valid mobile number ");
                goto RegStart4;
            }
        RegStart5:
            Console.WriteLine(" Password Rules: ");
            Console.WriteLine("* Password should have minimum 8 characters(letters and digits)");
            Console.WriteLine("* Password should have at least 1 capital letter");
            Console.WriteLine(" Password should have at least 1 digit ");
            Console.WriteLine(" Enter Password ");
            string password = Console.ReadLine();
            bool checkPassword1 = userDetails.ValidatePasswordRule1(password);
            bool checkPassword2 = userDetails.ValidatePasswordRule2(password);
            bool checkPassword3 = userDetails.ValidatePasswordRule3(password);
            if (checkPassword1 == true && checkPassword2==true && checkPassword3==true)
                Console.WriteLine(" PASSWORD: " + password);
            else
            {
                Console.WriteLine(" Please enter valid password ");
                goto RegStart5;
            }
        }
    }
}
