namespace CreditCardInterest.Data
{
    public  interface IManageWallets
    {
        void GiveWallet(Wallet newWallet);

        void TakeWallet(Wallet wallet);
    }
}