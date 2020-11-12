using System.Collections.Generic;

namespace CreditCardInterestTest.Data
{
    public abstract class PersonBase
    {
        protected List<Wallet> Wallets { get; set; }

        public abstract double CalculateSimpleInterest();


    }
}