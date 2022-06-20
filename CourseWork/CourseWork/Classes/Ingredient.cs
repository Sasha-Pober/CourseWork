using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Ingredient
    {
        public string name { get; set; }
        public int count { get; set; }

        public Ingredient(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
    }
}
