using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW06_25
{
    internal class RückblickReadLine2
    {
        static void Main(string[] args)
        {
            // Try.Parse ist eine spezielle Methode. Funktioniert nur mit string, int (double) und bool


            string myString;
            int zahl;
            bool istZahl;


            do
            {

                Console.WriteLine("Gib eine Zahl ein:");
                myString = Console.ReadLine();

                istZahl = int.TryParse(myString, out zahl);

                if (istZahl)
                {
                    Console.WriteLine("Korrekt! Du hast eine Zahl eingegeben");
                } else
                {
                    Console.WriteLine("Falsch! Gib eine Zahl ein!");
                }




            } while (!istZahl);









        }
    }
}
