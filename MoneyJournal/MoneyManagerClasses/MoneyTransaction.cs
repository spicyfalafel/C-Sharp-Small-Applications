using System;

namespace MoneyManagerClasses
{
    public class MoneyTransaction
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Day { get; set; }

        public bool IsCosts;
        public MoneyTransaction() { }
        public override string ToString()
        { 
            return $"{Name}: {Price}";
        }

        public MoneyTransaction(string name, decimal price, DateTime day)
        {
            Name = name;
            Price = price;
            Day = day;
        }
    }
}
