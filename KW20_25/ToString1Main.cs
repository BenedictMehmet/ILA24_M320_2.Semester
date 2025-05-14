using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class ToString1Main
    {
        static void Main(string[] args)
        {
            ToString1 t1 = new ToString1("Max", 22);

            t1.GibInfo();

            Console.WriteLine(t1);
        }
    }
}
