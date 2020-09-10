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
            var person = new Person()
            {
                Wallets = new List<Wallet>()
                {
                    new Wallet(){
                        Cards = new List<CreditCard>
                        {
                            new Visa(100),
                            new Mastercard(100),
                            new Discover(100)
                        }
                    }
                }
            };

            Assert.IsTrue(person.SimpleInterest == 16d);
            Assert.IsTrue(person.Wallets.First().Cards[0].SimpleInterest == 10d);
            Assert.IsTrue(person.Wallets.First().Cards[1].SimpleInterest == 5d);
            Assert.IsTrue(person.Wallets.First().Cards[2].SimpleInterest == 1d);
        }

        [TestMethod]
        public void OnePersonTwoWallets()
        {
            var person = new Person()
            {
                Wallets = new List<Wallet>()
                {
                    new Wallet(){
                        Cards = new List<CreditCard>
                        {
                            new Visa(100),
                            new Discover(100)
                        }
                    },
                    new Wallet(){
                        Cards = new List<CreditCard>
                        {
                            new Mastercard(100)
                        }
                    },
                }
            };

            Assert.IsTrue(person.SimpleInterest == 16d);
            Assert.IsTrue(person.Wallets[0].SimpleInterest == 11d);
            Assert.IsTrue(person.Wallets[1].SimpleInterest == 5d);
        }

        [TestMethod]
        public void TwoPersonsOneWalletEach()
        {
            var person1 = new Person()
            {
                Wallets = new List<Wallet>()
                {
                    new Wallet(){
                        Cards = new List<CreditCard>
                        {
                            new Visa(100),
                            new Mastercard(100),
                            new Discover(100)
                        }
                    }
                }
            };

            var person2 = new Person()
            {
                Wallets = new List<Wallet>()
                {
                    new Wallet(){
                        Cards = new List<CreditCard>
                        {
                            new Visa(100),
                            new Mastercard(100)
                        }
                    }
                }
            };

            Assert.IsTrue(person1.SimpleInterest == 16d);
            Assert.IsTrue(person1.Wallets[0].SimpleInterest == 16d);

            Assert.IsTrue(person2.SimpleInterest == 15d);
            Assert.IsTrue(person2.Wallets[0].SimpleInterest == 15d);
        }
    }
}
