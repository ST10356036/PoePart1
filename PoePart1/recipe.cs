using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeNamespace
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public Step[] Steps { get; set; }

        public Recipe(string name, Ingredient[] ingredients, Step[] steps)
        {
            RecipeName = name;
            Ingredients = ingredients;
            Steps = steps;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {RecipeName}\n");

            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }
    }
}

