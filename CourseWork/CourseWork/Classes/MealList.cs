using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork
{
    class MealList : ISerialize
    {
        public List<Dish> mealList = new List<Dish>();

        public int Length { get { return mealList.Count; } }

        public void addItem(Dish a)
        {
            mealList.Add(a);
        }

        public void fromFile(string path)
        {
            string list = File.ReadAllText(path);
            mealList = JsonConvert.DeserializeObject<List<Dish>>(list);
        }

        public void toFile(string path)
        {
            string text = JsonConvert.SerializeObject(mealList);
            File.WriteAllText(path, text);
        }

        public void addToFile(string path)
        {
            string text = File.ReadAllText(path);
            List<Dish> list = JsonConvert.DeserializeObject<List<Dish>>(text);

            if(list != null)
            mealList.AddRange(list);

            text = JsonConvert.SerializeObject(mealList);
            File.WriteAllText(path, text);
        }
            
        

    }
}
