using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest.Data
{
    public class CreditCard : CreditCardBase
    {
        public CreditCard()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public override double GetSimpleInterest() {
            return this.Balance * this.InterestRate;
        }
    }
}
