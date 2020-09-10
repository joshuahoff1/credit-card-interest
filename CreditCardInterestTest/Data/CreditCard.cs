using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestTest.Data
{
    public class CreditCard
    {
        public double InterestRate { get; set; }

        public double Balance { get; set; }

        public double SimpleInterest {
            get
            {
                return this.Balance * this.InterestRate;
            }
        }
    }
}
