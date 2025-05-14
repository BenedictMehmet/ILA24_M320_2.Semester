﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class TryCatch2
    {
        static void Main(string[]args)
        {
            int age = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Gib dein Alter ein:");
                string myInput = Console.ReadLine();

                try
                {
                    age = ErhalteAlter(myInput);
                    validInput = true;

                } catch (Exception ex)
                {
                    Console.WriteLine("Fehler: " + ex.Message);
                    Console.WriteLine("Versuche es erneut");
                } finally
                {
                    Console.WriteLine($"Dein Alter ist: {myInput}");
                }

                Console.ReadKey();


            }
        }


        static int ErhalteAlter(string input)
        {
            if (!int.TryParse(input, out int age))
            {
                throw new Exception("Keine gültige Zahl");
               
            }

            if(age < 0 || age > 140)
            {
                throw new Exception("Dein Alter muss zwischen 0 und 140 liegen");
            }

            return age;
        }
    }
}
