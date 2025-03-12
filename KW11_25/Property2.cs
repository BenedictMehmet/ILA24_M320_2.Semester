using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class Property2
    {
        private string _name;
        private string _adresse;
        private string _number;
        private int _yob;


        public int Yob
        {
            get
            {
                return DateTime.Now.Year - _yob;
            }
        }

        public Property2(string name, string adresse, string number, int yob)
        {
            this._name = name;
            this._adresse = adresse;
            this._number = number;
            this._yob = yob;
        }

        public Property2(string name)
        {
            this._name = name;
        }

        public Property2(string name, int yob)
        {
            this._name = name;
            this._yob = yob;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Adresse: {_adresse}");
            Console.WriteLine($"Nummer: {_number}");
            Console.WriteLine($"YOB: {_yob}");
           
        }
    }
}
