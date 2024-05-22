using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Airman Felix Ticketing System";

            Console.WriteLine("Welcome To Our Movie Box Subscription\nInput Your cash To Recieve the ticket.");




            int cash = Convert.ToInt32(Console.ReadLine());

            if(cash < 5)
            {
                Console.WriteLine("Your Input is Less Than 5 Dollars");
            }

            else if(cash == 5)
            {
                Console.WriteLine("Congratulations Here is Your Ticket");
            }

            else
            {
                int change = cash - 5;
                Console.WriteLine("Congratulations Here is Your Ticket and Balance of shillings " + change);
            }

            Console.ReadKey();
  
        }
    }
}
