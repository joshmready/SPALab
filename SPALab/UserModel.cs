using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPALab
{
    public class UserModel
    {
        public decimal Cash { get; set; }

        public decimal BitCoin { get; set; }

        public decimal Etherium { get; set; }

        public decimal LiteCoin { get; set; }

        //ctors
        public UserModel()
        {
            Cash = 5000;
        }

        public UserModel(decimal cash, decimal bitCoin, decimal etherium, decimal liteCoin)
        {
            Cash = cash >= 5000 ? cash : 5000;
            BitCoin = bitCoin;
            Etherium = etherium;
            LiteCoin = liteCoin;
        }

        //methods
        public string PurchaseCurrency(ConsoleKey purchasedCurrency, decimal cashSpent)
        {

            string message = "";

            if (cashSpent <= Cash)
            {
                Cash -= cashSpent;

                switch (purchasedCurrency)
                {
                    case ConsoleKey.B:
                        BitCoin += cashSpent / 7480;
                        message = $"You've purchased {(cashSpent / 7480):n2} amount of BitCoin!";
                        break;

                    case ConsoleKey.E:
                        Etherium += cashSpent / 586.15m;
                        message = $"You've purchased {(cashSpent / 586.15m):n2} amount of Etherium!";
                        break;

                    case ConsoleKey.L:
                        LiteCoin += cashSpent / 119.04m;
                        message = $"You've purchased {(cashSpent / 119.04m):n2} amount of LiteCoin!";
                        break;
                }
            }
            else
            {
                message = "Insufficient funds to make this purchase at this time. Check your account.";
            }

            return message;
            
        }
    }
}
