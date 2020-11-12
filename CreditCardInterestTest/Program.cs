using CreditCardInterestTest.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CreditCardInterestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var wallet = new Wallet();

            wallet.AddCard(new Visa(100));
            wallet.AddCard(new Mastercard(100));
            wallet.AddCard(new Discover(100));

            person.GiveWallet(wallet);


            Console.WriteLine(person.CalculateSimpleInterest());
            Console.ReadKey();
        }
    }
}
