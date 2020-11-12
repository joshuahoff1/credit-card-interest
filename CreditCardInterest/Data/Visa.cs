using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest.Data
{
    public class Visa : CreditCard
    {
        public Visa()
        {
            this.InterestRate = .1;
        }

        public Visa(double balance): this()
        {
            this.Balance = balance;
        }
    }
}
