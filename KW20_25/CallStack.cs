using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class CallStack
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Applikation startet bevor Try");

            try
            {
                LevelOne();
            } catch (Exception ex)
            {
                Console.WriteLine("Exception in MainBlok: " + ex.Message);
            }

            Console.WriteLine("Applikation läuft weiter");

            Console.ReadKey();
           
        }



        static void LevelOne()
        {
            LevelTwo();
        }


        static void LevelTwo()
        {
            Console.WriteLine("Level zwei bevor Throw");
            throw new Exception("Etwas ist Falsch");
            Console.WriteLine("Level zwei nach Throw");
        }
    }
}
