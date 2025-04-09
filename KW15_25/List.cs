using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25
{
    internal class List
    {
        static void Main(string[]args)
        {
            List<string> names = new List<string>();

            names.Add("Bob");
            names.Add("Max");


            foreach(string n1 in names)
            {
                Console.WriteLine(n1);
            }

            names.Remove("Max");

            foreach (string n1 in names)
            {
                Console.WriteLine(n1);
            }
        }
    }
}
