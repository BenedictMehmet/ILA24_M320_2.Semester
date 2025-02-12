using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW07_25
{
    class Array4
    {
        public string Name;
        public string Adresse;

        public void KundenInformatioen()
        {
            Array4[] infos = new Array4[]
            {

               new Array4 {Name = "Deniz", Adresse = "Hauptstrasse 2"},
               new Array4 {Name = "Peter", Adresse = "Hauptstrasse 5"}

            };

            foreach(Array4 kunden in infos)
            {
                Console.WriteLine($"Name: {kunden.Name}, Adresse {kunden.Adresse}");
            }
        }



        
    }
}
