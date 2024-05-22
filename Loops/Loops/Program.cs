using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate numbers from 1 to 10
            /*for(int i = 0; i < 10; i++)
            {
                Console.Write(i + 1);
            }*/
            Console.WriteLine("How many Cool Numbers Do You Want TO Generate ");

            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
