using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyManagerClasses
{
    public class Costs : MoneyTransaction
    {

        public Costs() { IsCosts = true; }
        public Costs(string name, decimal price, DateTime day) : base(name, price, day)
        {
            IsCosts = true;
        }
    }
}
