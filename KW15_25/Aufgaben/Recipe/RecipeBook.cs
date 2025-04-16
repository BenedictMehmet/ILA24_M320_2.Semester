using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25.Aufgaben.Recipe
{
    internal class RecipeBook
    {
        List<Recipe> recipes = new List<Recipe>();

        public void AddRecipe()
        {
            Console.Write("Name des Rezepts: ");
            string name = Console.ReadLine();

            Console.Write("Anzahl der Zutaten");
            int anzahlZutaten = int.Parse(Console.ReadLine());
            string[] listeZutaten = new string[anzahlZutaten];
            
            for(int i = 0; i < anzahlZutaten; i++)
            {
                Console.Write($"Zutat {i + 1}");
                listeZutaten[i] = Console.ReadLine();
            }


            Console.Write("Anzahl der Zutaten");
            int anzahlSchritte = int.Parse(Console.ReadLine());
            string[] listeSchritte = new string[anzahlZutaten];

            for (int i = 0; i < anzahlSchritte; i++)
            {
                Console.Write($"Zutat {i + 1}");
                listeSchritte[i] = Console.ReadLine();
            }

            recipes.Add(new Recipe(name, listeZutaten, listeSchritte));
        }

        private void DisplayIngredients(Recipe r)
        {
            string strich = "-";
            Console.WriteLine("Zuaten");
            for(int i = 0; i < r.Ingredients.Length; i++)
            {
                Console.Write(strich);
                Console.WriteLine(r.Ingredients[i]);
            }
        }

        private void DisplayPreperationStep(Recipe r)
        {
            string strich = "-";
            Console.WriteLine("Zubereitungsschritte");
            for (int i = 0; i < r.PreperationStep.Length; i++)
            {
                Console.Write(strich);
                Console.WriteLine(r.PreperationStep[i]);
            }
        }

        public void ShowAllRecipes()
        {
            Console.WriteLine("Alle Rezpete");
            int rezeptNummer = 1;

            foreach(Recipe r in recipes)
            {
                Console.WriteLine($"Rezept {rezeptNummer++}: {r.Name}");
                DisplayIngredients(r);
                DisplayIngredients(r);
            }

            Console.WriteLine();
        }
    }
}
