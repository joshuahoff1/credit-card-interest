﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterestTest.Data
{
    public class Mastercard: CreditCard
    {
        public Mastercard()
        {
            this.InterestRate = .05;
        }

        public Mastercard(double balance) : this()
        {
            this.Balance = balance;
        }

    }
}
