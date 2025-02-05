using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW06_25
{
    internal class RückblickReadLine1
    {
        static void Main(string[] args)
        {

            string name;
            int alter;
            double alter1 = 14;
            bool istZahl;
            char zeichen = '@';


            Console.WriteLine("Geben Sie ihren Namen ein:");
            name = Console.ReadLine();


            Console.WriteLine("Geben Sie ihr Alter ein:");
            alter = Convert.ToInt32(Console.ReadLine());
            alter = int.Parse(Console.ReadLine());


            string zahl1 = "5.5";

           

            int zahl2 = int.Parse(zahl1);
            int zahl3 = Convert.ToInt32(zahl1);






        }
    }
}
