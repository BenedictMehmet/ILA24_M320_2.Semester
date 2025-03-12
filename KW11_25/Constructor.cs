using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class Constructor
    {
        public string name;
        public string adresse;
        public string nummer;

        private static int nextID = 1;
        private readonly int id;



        public Constructor (string name, string adresse, string nummer)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = adresse;
            this.nummer = nummer;
        }

        public Constructor(string name, string adresse)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = adresse;
            this.nummer = "Nicht definiert!";
        }

        public Constructor(string name)
        {
            this.id = nextID++;
            this.name = name;
            this.adresse = "Nicht definiert";
            this.nummer = "Nicht definiert!";
        }

        public  void ZeigePersonen()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Adresse: {adresse}");
            Console.WriteLine($"Nummer: {nummer}");
        }

       
    }
}
