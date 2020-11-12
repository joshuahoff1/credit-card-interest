using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest.Data
{
    public class Discover : CreditCard
    {
        public Discover()
        {
            this.InterestRate = .01;
        }

        public Discover(double balance) : this()
        {
            this.Balance = balance;
        }

    }
}
