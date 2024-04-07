using System;
using RecipeNamespace;

namespace MainNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the recipe:");
            string recipeName = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());

            Ingredient[] ingredients = new Ingredient[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter ingredient {i + 1} details (name, quantity, unit):");
                string[] ingredientDetails = Console.ReadLine().Split(' ');
                ingredients[i] = new Ingredient { Name = ingredientDetails[0], Quantity = double.Parse(ingredientDetails[1]), Unit = ingredientDetails[2] };
            }

            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            Step[] steps = new Step[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1} description:");
                steps[i] = new Step { Description = Console.ReadLine() };
            }

            Recipe recipe = new Recipe(recipeName, ingredients, steps);

            recipe.DisplayRecipe();
        }
    }
}
