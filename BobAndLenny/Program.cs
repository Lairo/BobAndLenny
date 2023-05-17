using System;

namespace BobAndLenny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy Joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy Larry = new Guy() { Cash = 100, Name = "Larry" };

            while (true)
            {
                Joe.WriteMyInfo();
                Larry.WriteMyInfo();

                Console.WriteLine("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {

                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy.ToLower() == "joe" && Joe.Cash >= 0 )
                    {
                        int result = Joe.GiveCash(amount);                                                
                        Larry.ReceiveCash(result);

                    }
                    else if (whichGuy.ToLower() == "larry" && Larry.Cash >= 0)
                    {
                        int result =  Larry.GiveCash(amount);
                        Joe.ReceiveCash(result);
                    }
                    else

                        Console.WriteLine("Please enter 'Joe' or 'Larry'");

                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}

