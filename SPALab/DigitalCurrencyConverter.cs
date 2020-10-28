using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPALab
{
    public class DigitalCurrencyConverter
    {
        static void Main(string[] args)
        {
            bool loopOn = true;
            ConsoleKey currencyChoice = ConsoleKey.Escape;
            UserModel newUser = new UserModel(5000, 0, 0, 0);

            Console.WriteLine("Welcome! How can I help you?\n1) Purchase digital currency using cash\n2)Sell digital currency for cash\n3)View all account balances\n4)Transfer between digital currency types\n");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Please choose a currency to buy:\nB)itcoin\nE)therium\nL)iteCoin\n");
                    do
                    {
                        currencyChoice = Console.ReadKey().Key;
                        if (currencyChoice == ConsoleKey.B || currencyChoice == ConsoleKey.E || currencyChoice == ConsoleKey.L)
                        {
                            //we're good
                            loopOn = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please choose a currency to buy:\nB)itcoin\nE)therium\nL)iteCoin\n");
                        }
                    } while (loopOn);
                    Console.WriteLine("\nHow much cash worth of currency would you like to purchase?");
                    decimal currency = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(newUser.PurchaseCurrency(currencyChoice, currency));
                    break;
                case ConsoleKey.D2:
                    //newUser.SellDigitalCurrency
                    break;
                case ConsoleKey.D3:
                    //newUser.ViewAccounts
                    break;
                case ConsoleKey.D4:
                    //newUser.Transfer
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.Escape:
                    //end app
                    break;
                default:
                    //Error
                        break;
            }
        }
    }
}
