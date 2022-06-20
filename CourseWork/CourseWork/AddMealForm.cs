using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddMealForm : Form
    {
        MealList list = new MealList();
        public AddMealForm()
        {
            InitializeComponent();
        }

        private List<Ingredient> createIngredientList()
        {
            List<Ingredient> l = new List<Ingredient>();
            List<string> names = IngredientBox.Text.Split(',').ToList();
            foreach(var i in names)
            {
                l.Add(new Ingredient(i, 1));
            }

            return l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != "" && calBox.Text != "" && rateBox.Text != "" && typeBox.Text != "" && weightBox.Text != "" && IngredientBox.Text != "")
            {
                list.addItem(new Dish(typeBox.Text, nameBox.Text, rateBox.Text, int.Parse(calBox.Text), int.Parse(weightBox.Text), createIngredientList()));
                list.addToFile("data.txt");
                this.Close();
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }
            
        }

    }
}
