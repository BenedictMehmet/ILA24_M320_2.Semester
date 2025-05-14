using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class Dictionary
    {
        static void Main(string[]args)
        {
            Dictionary<int, string> Personen = new Dictionary<int, string>();

            Personen.Add(1, "Deniz");
            Personen.Add(2, "Bob");
            Personen.Add(3, "Max");

            string name = Personen[2];
            Console.WriteLine(name);

            Personen[3] = "Bob";

            string name1 = Personen[3];
            Console.WriteLine(name1);

            Personen.Remove(2);

            foreach (KeyValuePair<int, string> p in Personen)
            {
                Console.WriteLine($"ID: {p.Key} / Name: {p.Value}");
            }


            int counter = 1;

            while(Personen.ContainsKey(counter))
            {
                counter++;
            }

            Personen.Add(counter, "Peter");


            foreach (KeyValuePair<int, string> p in Personen)
            {
                Console.WriteLine($"ID: {p.Key} / Name: {p.Value}");
            }




        }
    }
}
