using System;
using System.Collections.Generic;
using System.Text;

namespace CookClasses
{
    public class Ingredient
    {
        string Name;
        Measure measure;
        int Amount;
        
        public Ingredient() { }
        public Ingredient(string name, Measure measure, int amount)
        {
            this.Name = name;
            this.measure = measure;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return $"{Name}: {Amount} of {measure}";
        }
    }
}
