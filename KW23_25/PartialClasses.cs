using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW23_25
{
    internal class PartialClasses
    {
        static void Main(string[]args)
        {
            Person p1 = new Person();
            p1.Name = "Deniz";
            p1.Age = 25;
            p1.JobTitle = "Informatiker";
            p1.Salary = 5000;

            p1.AssignedJob("Schreiner");
        }
    }





    partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    partial class Person
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }

    partial class Person
    {
        public void AssignedJob(string jobTitle)
        {
            this.JobTitle = jobTitle;
        }
    }
}
