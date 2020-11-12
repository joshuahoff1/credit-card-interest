namespace CreditCardInterest.Data
{
    public abstract class CreditCardBase
    {
        public double InterestRate;

        public double Balance;

        public string Id { get; protected set; }

        public abstract double GetSimpleInterest();
    }
}