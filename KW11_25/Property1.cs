using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW11_25
{
    class Property1
    {
        public int Speed {  get{ return _speed; }
            
            // private set....
             set
            {
                if(value >= 0 && value <= 210)
                {
                    _speed = value;
                }
            }
        }

        private int _speed = 50;

        public void Drive()
        {
            Console.WriteLine($"Das Auto fährt mit {_speed} km/h.");
        }


    }
}
