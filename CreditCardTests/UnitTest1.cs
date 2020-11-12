using CreditCardInterestTest.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CreditCardTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnePersonOneWallet()
        {
            var person = new Person();
            var wallet = new Wallet();
            
            var visaId = wallet.AddCard(new Visa(100));
            var masterId = wallet.AddCard(new Mastercard(100));
            var discId = wallet.AddCard(new Discover(100));

            person.GiveWallet(wallet);

            Assert.IsTrue(person.CalculateSimpleInterest() == 16d);
            Assert.IsTrue(wallet.retrieveCard(visaId).GetSimpleInterest() == 10d);
            Assert.IsTrue(wallet.retrieveCard(masterId).GetSimpleInterest() == 5d);
            Assert.IsTrue(wallet.retrieveCard(discId).GetSimpleInterest() == 1d);
        }

        [TestMethod]
        public void OnePersonTwoWallets()
        {
            var person = new Person();

            var wallet1 = new Wallet();
            wallet1.AddCard(new Visa(100));
            wallet1.AddCard(new Discover(100));
            person.GiveWallet(wallet1);

            var wallet2 = new Wallet();
            wallet2.AddCard(new Mastercard(100));
            person.GiveWallet(wallet2);


            Assert.IsTrue(person.CalculateSimpleInterest() == 16d);
            Assert.IsTrue(wallet1.GetSimpleInterest() == 11d);
            Assert.IsTrue(wallet2.GetSimpleInterest() == 5d);
        }

        [TestMethod]
        public void TwoPersonsOneWalletEach()
        {
            var person1 = new Person();
            var wallet1 = new Wallet();

            wallet1.AddCard(new Visa(100));
            wallet1.AddCard(new Mastercard(100));
            wallet1.AddCard(new Discover(100));

            person1.GiveWallet(wallet1);


            var person2 = new Person();
            var wallet2 = new Wallet();

            wallet2.AddCard(new Visa(100));
            wallet2.AddCard(new Mastercard(100));

            person2.GiveWallet(wallet2);

            Assert.IsTrue(person1.CalculateSimpleInterest() == 16d);
            Assert.IsTrue(wallet1.GetSimpleInterest() == 16d);

            Assert.IsTrue(person2.CalculateSimpleInterest() == 15d);
            Assert.IsTrue(wallet2.GetSimpleInterest() == 15d);
        }
    }
}
