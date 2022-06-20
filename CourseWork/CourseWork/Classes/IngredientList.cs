using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork
{
    class IngredientList : ISerialize
    {
        public List<Ingredient> Ingredients = new List<Ingredient>();

        public int Length { get { return Ingredients.Count; } }

        public void Add(Ingredient a)
        {
            Ingredients.Add(a);
        }

        public void fromFile(string path)
        {
            string list = File.ReadAllText(path);
            Ingredients = JsonConvert.DeserializeObject<List<Ingredient>>(list);
        }

        public void toFile(string path)
        {
            string text = JsonConvert.SerializeObject(Ingredients);
            File.WriteAllText(path, text);
        }

        public void deleteDuplicates()
        {
            List<string> l = Ingredients.Select(n => n.name).ToList();
            l = l.Distinct().ToList();
            Ingredients.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                Ingredients.Add(new Ingredient(l[i], 10));
            }
        }
    }
}
