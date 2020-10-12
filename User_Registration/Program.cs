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

        }
    }
}
