using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class ConstrucorMain
    {
        static void Main(string[]args)
        {

            // public Constructor(string name, string adresse, string nummer)
            Constructor person1 = new Constructor("Deniz" , "Haldestrass", "049435");

            Constructor person2 = new Constructor("Bob", "Tannenstrasse");

            person1.ZeigePersonen();
            person2.ZeigePersonen();

           
        }
    }
}
