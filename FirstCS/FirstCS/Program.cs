using System;

namespace FirstCS
{
    class Progam
    {
        static void Main(String[]args)
        {
            Console.Title = "Airman Felix"; //This is used to change the title of our Terminal
            Console.ForegroundColor = ConsoleColor.Green; //used to change the color of our text
            Console.WindowHeight = 40; // used to change the height of our terminal
            
            Console.WriteLine("Hello everyone"); //used to print Hello Worl on the terminal
            Console.ReadKey(); //used to prevent our terminal from closing before pressing any key

            //Console in this case is a class which is like a container which has items in it
            //Under the Console class the members of the class can have range(Spanner) icon or the box icon
            //The box icons are the methods or functions which are commands called to execute tasks such as printing on the terminal 
            //.WriteLine is an example of the method and also .Readkey
            //The range icon are variables or property which can be used to modify the console such as title or color
            //.Title, .Foreground, . WindowHeight are examples of variables or property within the Console Class


        }
    }
}