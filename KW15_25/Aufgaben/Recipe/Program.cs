using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25.Aufgaben.Recipe
{
    internal class Program
    {
        static void Main(string[]args)
        {
            RecipeBook rb = new RecipeBook();

            bool running = true;

            while(running)
            {
                Console.WriteLine("1. Neues Rezept hinzufügen");
                Console.WriteLine("2. Alle Rezepte anzeigen");
                Console.WriteLine("3. Beenden");
                Console.WriteLine();
                Console.WriteLine("Wähle eine Option aus");

                string eingeben = Console.ReadLine();



            }
        }
    }
}
