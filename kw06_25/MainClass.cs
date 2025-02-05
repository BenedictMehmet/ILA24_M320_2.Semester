using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW06_25
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            Method1 method1 = new Method1();
            method1.ZeigeNachricht();


            Method2 method2 = new Method2();
            method2.AddiereZahlen();


            Method3 method3 = new Method3();
            method3.AusgangsRegel();
          


            MethodParameter1 methodParameter1 = new MethodParameter1();

            methodParameter1.Addieren(5, 10);
            methodParameter1.Addieren(10, 33);
            int ergebnis = methodParameter1.Addieren(21, 22);


            MethodParameter2 methodParameter2 = new MethodParameter2();

            Console.WriteLine("Wie heisst du?");
            string myName = Console.ReadLine();
            methodParameter2.Begrüssung(myName);




            MethodReturnBool methodBool = new MethodReturnBool();

            Console.WriteLine("Gib eine Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            bool ab = methodBool.istGerade(zahl1);

            if (ab) {

                Console.WriteLine("Die Zahl ist gerade");
            } else
            {
                Console.WriteLine("Die Zahl ist ungerade");
            }


        }
    }
}
