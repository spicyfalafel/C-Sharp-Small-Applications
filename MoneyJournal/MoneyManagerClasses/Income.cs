using MoneyManagerClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManager
{
    public class Income : MoneyTransaction
    {
        public Income() {
            IsCosts = false;
        }
        public Income(string name, decimal price, DateTime day) : base(name, price, day)
        {
            IsCosts = false;
        }
    }
}
