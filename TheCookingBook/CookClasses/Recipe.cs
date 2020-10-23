using System;
using System.Collections.Generic;
using System.Text;

namespace CookClasses
{
    public class Recipe
    {
        public string Name;
        public DishCategory category { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public string Description { get; set; } = "no description yet";

        public Recipe(string name, DishCategory category, List<Ingredient> ingredients)
        {
            Name = name;
            this.category = category;
            this.ingredients = ingredients; 
        }
    }
}
