using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class MemberVariable
    {
        static void Main(string[]args)
        {
            memberVariable person1 = new memberVariable();

            person1.name = "Deniz";
            Console.WriteLine(person1.name);




            memberVariable person2 = new memberVariable();

            person2.setAdresse("Haldestrass");
            Console.WriteLine(person2.getAdresse());



            memberVariable person3 = new memberVariable();
            //person3.Nummer = "4554534";
        }
    }


    class memberVariable
    {
        public string name;

        private string adresse;

        public string Nummer { get; private set; }



        public void setAdresse(string adr)
        {
            adresse = adr;
        }

        public string getAdresse()
        {
            return adresse;
        }


    }
}
