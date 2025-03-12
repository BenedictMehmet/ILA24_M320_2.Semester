using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW07_25.Übungen.Lösungen
{
    class Lösung1
    {
        static void Main(string[] args)
        {
            string rakete = "R";

            for(int i = 0; i <= 10; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(rakete);
                    Thread.Sleep(800);
                    Console.Clear();
                }

                if (i == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\t{rakete}");
                    Thread.Sleep(800);
                    Console.Clear();
                }

                if (i == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"\t\t{rakete}");
                    Thread.Sleep(800);
                    Console.Clear();
                }
            }

            Console.WriteLine("Es wurde gelandet");


        }
    }
}
