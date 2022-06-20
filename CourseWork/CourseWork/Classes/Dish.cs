using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Dish : Cuisine
    {
        public string name { get; set; }
        public string rate { get; set; }
        public int calories { get; set; }
        public int weight { get; set; }

        public List<Ingredient> ingredients { get; set; }

        public Dish(string type, string name, string rate, int cal, int mass, List<Ingredient> components) : base(type)
        {
            this.name = name;
            this.rate = rate;
            this.calories = cal;
            this.weight = mass;
            ingredients = components;
        }

        public string getListStr()
        {
            string res = " ";
            foreach (var i in ingredients)
            {
                res += i.name + " ";
            }
            return res;
        }
    }
}
