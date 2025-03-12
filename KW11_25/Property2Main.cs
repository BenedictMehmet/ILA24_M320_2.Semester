using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class Property2Main
    {
        static void Main(string[]args)
        {
            Property2 person1 = new Property2("Deniz", "Haldenstrasse", "12345", 1995);

            person1.ShowDetails();

            Console.WriteLine($"Deniz ist {person1.Yob} Jahre alt");
        }
    }
}
