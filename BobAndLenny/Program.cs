using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobAndLenny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy.ToLower() == "joe")
                    {

                    }
                    else if{ whichGuy.ToLower() == "larry" }
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Larry'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
