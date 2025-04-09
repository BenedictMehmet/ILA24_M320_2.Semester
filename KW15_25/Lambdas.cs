using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25
{
    internal class Lambdas
    {
        static void Main(string[]args)
        {
            List<int> numbers = new List<int>() { 34, 55, 10, 8, 9, 66, 88, 4 };


            List<int> higherTen = numbers.FindAll(x => x > 10);

            foreach(int ten in higherTen)
            {
                Console.WriteLine(ten);
            }
        }
    }
}
