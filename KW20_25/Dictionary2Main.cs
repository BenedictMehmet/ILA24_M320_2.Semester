using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class Dictionary2Main
    {
        static void Main(string[]args)
        {
            Dictionary<int, Dictionary2> Mitarbeiter = new Dictionary<int, Dictionary2>();


            Mitarbeiter.Add(1, new Dictionary2("Deniz", 35, 5000));
            Mitarbeiter.Add(2, new Dictionary2("Bob", 20, 3000));
            Mitarbeiter.Add(3, new Dictionary2("Max", 24, 4000));

           // foreach (KeyValuePair<int, string> p in Personen)

            foreach (KeyValuePair<int, Dictionary2> p in Mitarbeiter)
            {
                Console.WriteLine($"ID: {p.Key} / Name: {p.Value.Name} / Alter: {p.Value.Age} / Lohn: {p.Value.Salaray}");
            }
        }
    }
}
