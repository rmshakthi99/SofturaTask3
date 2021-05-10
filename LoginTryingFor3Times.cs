using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    //question 5:Create a program that will take login details from user and print welcome if username is “Admin”
    //And password is “admin”(case sensitive). The user can try only 3 times max.If the user login fails the third time the application should state that and end

    class LoginTryingFor3Times
    {
        public static void Main(String[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the username");
                string Name = Console.ReadLine();
                Console.WriteLine("Please enter the password");
                string Password = Console.ReadLine();

                if (Name == "Admin" && Password == "admin")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username and password");
                }
                if (i == 2)
                {
                    Console.WriteLine("you have tried 3 times");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }


            }
        }
    }
}


       