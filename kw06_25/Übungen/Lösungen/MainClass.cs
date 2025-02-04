using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW06_25.Übungen.Lösungen
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Lösung1 nachricht = new Lösung1();
            nachricht.ZeigeNachricht();  // Methode aufrufen



            Lösung2 zahlen = new Lösung2();
            zahlen.ZeigeZahlen();  // Methode aufrufen
            Console.ReadKey();



            Lösung3 rechner = new Lösung3();
            rechner.Addiere(10, 15);  // Methode aufrufen mit zwei Zahlen



            Lösung4 begruessung = new Lösung4();

            Console.WriteLine("Gib deinen Namen ein:");
            string name = Console.ReadLine();

            begruessung.Begruesse(name);  // Methode aufrufen mit dem Namen




        }
    }
}
