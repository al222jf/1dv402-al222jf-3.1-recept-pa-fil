using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear();
            //Sätter headern till receptets namn och visar den.
            Header = recipe.Name;
            ShowHeaderPanel();
            Console.WriteLine("\nIngredienser\n============");

            //Skriver ut ingredienserna.
            foreach (IIngredient ingredients in recipe.Ingredients)
            {
                Console.WriteLine(ingredients);
            }
            Console.WriteLine("\nGör så här\n==========");

            //Skriver ut instruktionerna.
            foreach (string instructions in recipe.Instructions)
            {
                Console.WriteLine(instructions);
            }

        }
        public void Show(IEnumerable<IRecipe> recipes)
        {
            //Skriver ut varje helt recept med namn, ingredienser och instruktioner.
            foreach (IRecipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}
