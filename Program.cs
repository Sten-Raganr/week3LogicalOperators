using System;

namespace Week3logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter login.");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password.");
            string password = Console.ReadLine();
            if ((login == "admin") && (password == "pass1234"))
                Console.WriteLine("Welcome!");
            else if ((login == "admin") && (password != "pass1234"))
                Console.WriteLine("The password is incorrect, Try again.");
            else if ((login != "admin") && (password == "pass1234"))
                Console.WriteLine("Login is incorrect, Try again.");
            else Console.WriteLine("YOU SHALL NOT PASS!");

                


        }
    }
}
