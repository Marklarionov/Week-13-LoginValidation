using System;

namespace Inglise
{
    class Program
    {
        static void Main(string[] args)
        {
            //login: admin
            //password: pass1234

            //declare variables
            //asign value - initialize a variable
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;

            int tries = 0;
            while (tries != 3)
            {
                Console.WriteLine("Enter your login: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                userPassword = Console.ReadLine();

                if (login != userName || password != userPassword)
                {
                    Console.WriteLine("Oops. smth went wrong.");
                    tries++; //tries = tries + 1
                    Console.WriteLine($"Login failed. Attemps left {tries}");
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }
        }
    }
}
