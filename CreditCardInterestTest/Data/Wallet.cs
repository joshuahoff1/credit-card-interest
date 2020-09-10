using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCardInterestTest.Data
{
    public class Wallet
    {
        public List<CreditCard> Cards { get; set; }

        public double SimpleInterest { 
            get 
            {
                return Cards.Sum(x => x.SimpleInterest);
            } 
        }

        public Wallet()
        {
            Cards = new List<CreditCard>();
        }


    }
}
