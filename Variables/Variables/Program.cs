using System;

namespace Variables
{
    class Program
    
        static void Main(string[] args)
        {
            //Console.WriteLine("What Is Your Name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName + " Nice to meet you!!");
            Console.Title = "Airman Felix";

            double num1;
            double num2;

            Console.Write("Input The First Number ");
            num1 = Convert.ToDouble(Console.ReadLine()); //converting the input into a type interger because readline takes string values. We are using the convert class with a method of int32
            Console.Write("Input The Second number ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            double result = num1 * num2;
            
            Console.WriteLine("The Result is = " + result);

            Console.ReadKey();
        }
    }
}
