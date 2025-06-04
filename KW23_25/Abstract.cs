using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW23_25
{
    internal class Abstract
    {
        static void Main(string[]args)
        {
            Dog d = new Dog();
            d.MakeSound();
            d.Sleep();
        }
    }




    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }


    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miauing");
        }
    }

}
