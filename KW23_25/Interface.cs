using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW23_25
{
    internal class Interface
    {
        static void Main(string[]args)
        {
            Hase h = new Hase();
            h.Fliehen();
        }
    }



    interface Beute
    {
        void Fliehen();
    }


    interface Raubtier
    {
        void Jagd();
    }


    class Hase : Beute
    {
        public void Fliehen()
        {
            Console.WriteLine("Hase rennt weg");
        }
    }


    class Fisch : Beute, Raubtier
    {
        public void Fliehen()
        {
            Console.WriteLine("Fisch schwimmt weiter");
        }

        public void Jagd()
        {
            Console.WriteLine("Fisch sucht nach Nahrung");
        }
    }
}
