using System;

namespace Condition2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.WriteLine("Welcome To Our RollerCoaster\nInput Your Age In Years ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Your Age In Centimeters ");
            height = Convert.ToInt32(Console.ReadLine());

            //Nesting of conditons
            /*if(age >= 18)
            {
                if(height >= 150)
                {
                    Console.WriteLine("You Can Enter Into The RollerCoaster !!!");
                }
                else
                {
                    Console.WriteLine("You Can Not Enter The RollerCoaster!!!");
                }
            }*/

            // Using The OR(||) To Check If One Of The Condition Is True
            /*if(age >= 18 || height >= 150)
            {
                Console.WriteLine("You Can Enter Into The RollerCoaster!!!!!");
            }
            else
            {
                Console.WriteLine("You Cannot Enter Into The RollerCoaster!!");
            }

            if (age >= 18 && height >= 150)
            {
                Console.WriteLine("You Can Enter Into The RollerCoaster!!!!!");
            }
            else
            {
                Console.WriteLine("You Cannot Enter Into The RollerCoaster!!");
            }*/

            Console.ReadKey();
        }
    }
}
