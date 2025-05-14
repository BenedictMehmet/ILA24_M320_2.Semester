using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class ToString1
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public ToString1(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void GibInfo()
        {
            Console.WriteLine($"Name: {Name} / Alte: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name} / Alte: {Age}";
        }


        static void Main(string[]args)
        {
            ToString1 t1 = new ToString1();
        }


    }
}
