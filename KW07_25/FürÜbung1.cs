using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW07_25
{
    class FürÜbung1
    {
        static void Main(string[]args)
        {

         
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }


            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(10);
                Console.WriteLine(i);
            }

            Console.WriteLine("\t Deniz");

        }
    }
}
