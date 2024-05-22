using System;

namespace CLI_USSD
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************\nWELCOME TO AIRMAN FELIX USSD BANKING SOLUTION");
            Console.WriteLine("MENU:");
            Console.WriteLine("1.CHECK YOUR BANK BALANCE");
            Console.WriteLine("2.DEPOSIT MONEY");
            Console.WriteLine("3.WITHDRAW CASH");
            Console.WriteLine("4.SEND MONEY");
            Console.WriteLine("5.CHECK ACCOUNT NUMBER");
            Console.WriteLine("0:EXIT");
            Console.WriteLine("");
            Console.WriteLine("> ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("YOU HAVE EXITED SUCCESFULLY");
                    break;

                case 1:
                    Console.WriteLine("YOUR CURRENT ACCOUNT BALANCE IS KSH.0");
                    break;

                case 2:
                    Console.WriteLine("YOU HAVE DEPOSITED YOUR MONEY SUCCESFULLY");
                    break;

                case 3:
                    Console.WriteLine("YOU HAVE WITHDRAWN YOUR MONEY SUCCESFULLY");
                    break;

                case 4:
                    Console.WriteLine("YOU CANNOT SEND MONEY FOR NOW");
                    break;

                case 5:
                    Console.WriteLine("YOUR ACC IS: 1220569789822528554");
                    break;

                default:
                    Console.WriteLine("INCORRECT OPTION SELECTED");
                    break;



            }

            Console.ReadKey();



        }
    }
}
