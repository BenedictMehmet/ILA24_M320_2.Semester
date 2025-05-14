using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW20_25
{
    internal class ExceptionTypes
    {
        static void Main(string[]args)
        {
            int result = 0;

            try
            {
                Console.WriteLine("Gib eine Zahl ein");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;

            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            } catch(OverflowException ex)
            {
                Console.WriteLine("Wenn die Zahl sehr hoch ist: " + ex.Message);
            } catch (FormatException ex)
            {
                Console.WriteLine("Fehler, wenn ein Zeichen eingegeben wurde." + ex.Message);
            }
        }
    }
}
