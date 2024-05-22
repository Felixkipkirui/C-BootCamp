using System;

namespace SimpleCLILogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
            Console.WriteLine("WELCOME TO SIMPLE C# LOGIN");
            Console.WriteLine("TYPE IN YOUR USERNAME");
            username = Console.ReadLine();
            Console.WriteLine("TYPE IN YOUR PASSWORD");
            password = Console.ReadLine();

            if(username == "admin" && password == "123456789")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU CAN PROCEED TO THE ADMIN DASHBOARD");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOUR LOGIN CREDENTIALS ARE WRONG!!!");
            }

            Console.ReadKey();
        }
    }
}
