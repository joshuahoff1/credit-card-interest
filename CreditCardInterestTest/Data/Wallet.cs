using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestTest.Data
{
    public class Wallet : WalletBase, IManageCards
    {
        private Dictionary<string, CreditCard> Cards { get; set; }

        public override double GetSimpleInterest()
        { 
            return Cards.Sum(card => card.Value.GetSimpleInterest());
        }

        public Wallet()
        {
            Cards = new Dictionary<string, CreditCard>();
        }

        public string AddCard(CreditCard card)
        {
            Cards.Add(card.Id, card);
            return card.Id;
        }

        public void removeCard(CreditCard card)
        {
            Cards.Remove(card.Id);
        }

        public void EmptyWallet()
        {
            Cards.Clear();
        }

        public Wallet TransferTo(Wallet newWallet)
        {
            foreach (var card in Cards)
            {
                newWallet.AddCard(card.Value);
                Cards.Remove(card.Key);
            }

            return newWallet;
        }

        public CreditCard retrieveCard(string id)
        {
            Cards.TryGetValue(id, out CreditCard card);

            return card;
        }
    }
}
