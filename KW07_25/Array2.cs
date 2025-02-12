using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW07_25
{
    class Array2
    {
        static void Main(string[] args)
        {
            int[] nummer = new int[] { 33, 345543, 322, 34534};

            Console.WriteLine(nummer[0]);

            foreach(int r in nummer)
            {
                Console.WriteLine(r);
            }
        }
    }
}
