using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class Dictionary2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salaray { get; set; }

        public Dictionary2(string name, int age, int salaray)
        {
            this.Name = name;
            this.Age = age;
            this.Salaray = salaray;
        }
    }
}
