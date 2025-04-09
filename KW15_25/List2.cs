using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25
{
    internal class List2
    {
        static void Main(string[]args)
        {
            List<(string, int)> products = new List<(string, int)>
            {
                ("Zitrone", 4)
            };


            foreach((string,int) p in products)
            {
                Console.WriteLine(p.Item1 +" " +p.Item2);
            }
        }
    }
}
