using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA24_M320_2.Semester.KW15_25.Aufgaben.Recipe
{
    internal class Recipe
    {
        public string Name { get; set; }

        public string[] Ingredients { get; set; }

        public string[] PreperationStep { get; set; }

        public Recipe (string name, string[] ingredients, string[] preperationStep)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.PreperationStep = preperationStep;
        }
    }
}
