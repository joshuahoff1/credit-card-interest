using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Text;

namespace CreditCardInterestTest.Data
{
    public class Person
    {
        public List<Wallet> Wallets { get; set; }

        public double SimpleInterest
        {
            get
            {
                return Wallets.Sum(x => x.SimpleInterest);
            }
        }

        public Person()
        {
            Wallets = new List<Wallet>();
        }
    }
}
