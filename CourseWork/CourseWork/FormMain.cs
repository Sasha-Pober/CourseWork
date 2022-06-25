using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class FormMain : Form
    {
        MealList mealList = new MealList();

        public FormMain()
        {
            InitializeComponent();
            generateIngredients();
        }

        public void generateIngredients()
        {
            IngredientList list = new IngredientList();

            mealList.fromFile("data.txt");

            for(int i = 0; i < mealList.Length; i++)
            {
                for(int j = 0; j < mealList.mealList[i].ingredients.Count; j++)
                {
                    Ingredient temp = mealList.mealList[i].ingredients[j];
                    if (list.Ingredients.Contains<Ingredient>(temp) == false)
                    {
                        list.Add(temp);
                    }
                }
            }
            list.Ingredients = list.Ingredients.OrderBy(n => n.name).ToList();

            list.deleteDuplicates();
            
            list.toFile("IngredientData.txt");
        }

        private void GotoCuisines_Click(object sender, EventArgs e)
        {
            new CuisinesForm().Show();
        }

        private void OrderMeal_Click(object sender, EventArgs e)
        {
            new OrderMealForm().Show();
        }

        private void GenerateDinner_Click(object sender, EventArgs e)
        {
            new GenerateDinnerForm().ShowDialog();
        }

        private void CoockedMealsBtn_Click(object sender, EventArgs e)
        {
            new CookedMealsForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to quit?", "Program exiting", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                File.WriteAllText("CoockedData.txt", string.Empty);
                this.Close();
            }
        }

        private void InsertMealBtn_Click(object sender, EventArgs e)
        {
            new AddMealForm().ShowDialog();
        }
    }
}
