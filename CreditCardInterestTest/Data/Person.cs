using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Text;

namespace CreditCardInterestTest.Data
{
    public class Person : PersonBase, IManageWallets
    {
        public Person()
        {
            Wallets = new List<Wallet>();
        }

        public void GiveWallet(Wallet newWallet)
        {
            Wallets.Add(newWallet);
        }

        public void TakeWallet(Wallet wallet)
        {
            Wallets.Remove(wallet);
        }

        public override double CalculateSimpleInterest()
        {
            return Wallets.Sum(wallet => wallet.GetSimpleInterest());
        }
    }
}
