using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using a while loop to roll a six in a dice
            Random numberGen = new Random();

            int roll1 = 0;
            int roll2 = 0;
            int attempts = 0;
            Console.WriteLine("Press The Enter Key To Roll The Dice");

            while(roll1 == roll2)
            {
                Console.ReadKey();
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("You Rolled "+ roll1);
                Console.WriteLine("You Rolled " + roll2);
                Console.WriteLine();
                attempts++;
            }

            Console.WriteLine("It Took You " + attempts + " number of attempts to roll the number 6");

            Console.ReadKey();
        }
    }
}
