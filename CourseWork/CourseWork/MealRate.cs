using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class MealRate : Cuisine
    {
        public string rate { get; set; }

        public MealRate(string type, string rate) : base(type)
        {
            this.rate = rate;
        }
    }
}
