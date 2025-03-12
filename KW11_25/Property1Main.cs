using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class Property1Main
    {
        static void Main(string[]args)
        {
            Property1 car1 = new Property1();

            car1.Speed = -7;

            Console.WriteLine(car1.Speed);

            car1.Drive();
        }
    }
}
