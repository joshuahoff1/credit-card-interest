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
            var person = GeneratePerson();

            Console.WriteLine(person.SimpleInterest);
        }

        private static Person GeneratePerson()
        {
            return new Person()
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
        }
    }
}
