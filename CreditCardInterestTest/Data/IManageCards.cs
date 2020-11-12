
namespace CreditCardInterestTest.Data
{
    public interface IManageCards
    {
        string AddCard(CreditCard card);
        void removeCard(CreditCard card);
        CreditCard retrieveCard(string id);
        void EmptyWallet();
        Wallet TransferTo(Wallet newWallet);
    }
}