using System;

namespace SwitchCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Switch Statement Condition");

            int num;
            Console.Write("INPUT ANY NUMBER BETWEEN 1 AND 5 ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("YOU HAVE ENTERED ONE ");
                    break;

                case 2:
                    Console.WriteLine("YOU HAVE ENTERED TWO");
                    break;

                case 3:
                    Console.WriteLine("YOU HAVE ENTERED THREE");
                    break;

                case 4:
                    Console.WriteLine("YOU HAVE ENTERED FOUR");
                    break;

                case 5:
                    Console.WriteLine("YOU HAVE ENTRED FIVE");
                    break;

                default:
                    Console.WriteLine("YOU ARE OUT OF RANGE!!!!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
