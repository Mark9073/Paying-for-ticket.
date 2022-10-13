using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paying_for_ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conditions";

            Console.WriteLine("------Buying ticket for the show------");
            Console.ReadLine();
            Console.WriteLine("Please write your name!");
            string hisName = Console.ReadLine();

            Console.Write("Great " + hisName + " , please insert 5$ for the ticket!:");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.Write("That is not enough please insert more " + (5 - cash) + "$!:");
                int cashPlus = Convert.ToInt32(Console.ReadLine());

                if (cash + cashPlus == 5)
                {
                    Console.WriteLine("Here is your ticket " + hisName + " !");
                }
                else if (cash + cashPlus < 5)
                {
                    int x = 5 - (cash + cashPlus);
                    Console.Write("You need to insert " + x + "$ for full payment!");
                    Console.ReadLine();
                    Console.WriteLine("Here is your ticket!");
                    Console.ReadKey();
                }

            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket!");
                Console.ReadKey();
            }
            else if (cash > 5)
            {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and the " + change + " change dollars.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
