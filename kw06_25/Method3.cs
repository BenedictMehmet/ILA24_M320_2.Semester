using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW06_25
{
    internal class Method3
    {

        public void AusgangsRegel()
        {
            Console.WriteLine("Wie alt bist du?");
            int alter = int.Parse(Console.ReadLine());

            if (alter < 15) {

                Console.WriteLine("Du bist noch zu jung um raus zu gehen.");       
            }  else
            {
                Console.WriteLine("Du darfst raus gehen!");
            }
        }



    }
}
