using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25
{
    internal class List1Main
    {
        static void Main(string[]args)
        {
            List<List1> products = new List<List1>
            {
                new List1 {Name = "Zitronen", Price = 5},
                new List1 {Name = "Schokolade", Price = 3},
                new List1 {Name = "Apfel", Price = 1}
            };


            foreach(List1 p in products)
            {
                Console.WriteLine($"Name vom Produkt: {p.Name} / Preis: {p.Price}");

                

            }




        }
    }
}
