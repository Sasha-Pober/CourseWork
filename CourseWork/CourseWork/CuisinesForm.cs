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
    public partial class CuisinesForm : Form
    {
        MealList meal = new MealList();
        IngredientList products = new IngredientList();

        public CuisinesForm()
        {
            Visible = false;
            InitializeComponent();
            generateIngredients();
            createProductList();
            createMealList();
        }


        private void tableInsert(List<Dish> c)
        {
            foreach (var a in c)
            {
                listBox1.Items.Add(a.name);
                listBox2.Items.Add(a.calories);
                listBox3.Items.Add(a.weight);
                listBox4.Items.Add(a.getListStr());
            }
        }

        private void createProductList()
        {
            products.fromFile("IngredientData.txt");
            checkedListBox1.Items.AddRange(products.Ingredients.Select(n => n.name).ToArray());
        }

        private void createMealList()
        {
            meal.fromFile("data.txt");
        }

        private void clearAllLists()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Dish> items = new List<Dish>();

            clearAllLists();

            if (checkBox4.Checked)
            {
                
                for (int i = 0; i < meal.Length; i++)
                {
                    if(checkBox5.Checked)
                    {
                        for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
                        {
                            if (meal.mealList[i].getListStr().Contains(checkedListBox1.CheckedItems[j].ToString()) && items.Contains(meal.mealList[i]) == false)
                            {
                                items.Add(meal.mealList[i]);
                            }
                        }
                    }
                    else
                        items.Add(meal.mealList[i]);
                   
                }
                tableInsert(items);
            }
            else
            {
                if (checkBox1.Checked)
                {
                    for (int i = 0; i < meal.Length; i++)
                    {
                        if(checkBox5.Checked)
                        {
                            for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
                            {
                                if (meal.mealList[i].type == checkBox1.Text && meal.mealList[i].getListStr().Contains(checkedListBox1.CheckedItems[j].ToString()) && items.Contains(meal.mealList[i]) == false)
                                {
                                    items.Add(meal.mealList[i]);
                                }
                            }
                        }
                        else
                        {
                            if (meal.mealList[i].type == checkBox1.Text)
                            {
                                items.Add(meal.mealList[i]);
                            }
                        } 
                    }
                }

                if (checkBox2.Checked)
                {
                    for (int i = 0; i < meal.Length; i++)
                    {
                        if (checkBox5.Checked)
                        {
                            for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
                            {
                                if (meal.mealList[i].type == checkBox2.Text && meal.mealList[i].getListStr().Contains(checkedListBox1.CheckedItems[j].ToString()) && items.Contains(meal.mealList[i]) == false)
                                {
                                    items.Add(meal.mealList[i]);
                                }
                            }
                        }
                        else
                        {
                            if (meal.mealList[i].type == checkBox2.Text)
                            {
                                items.Add(meal.mealList[i]);
                            }
                        }
                    }
                }

                if (checkBox3.Checked)
                {
                    for (int i = 0; i < meal.Length; i++)
                    {
                        if (checkBox5.Checked)
                        {
                            for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
                            {
                                if (meal.mealList[i].type == checkBox3.Text && meal.mealList[i].getListStr().Contains(checkedListBox1.CheckedItems[j].ToString()) && items.Contains(meal.mealList[i]) == false)
                                {
                                    items.Add(meal.mealList[i]);
                                }
                            }
                        }
                        else
                        {
                            if (meal.mealList[i].type == checkBox3.Text)
                            {
                                items.Add(meal.mealList[i]);
                            }
                        }
                    }
                }

                tableInsert(items);
                
            }
           
        }

        public void generateIngredients()
        {
            IngredientList list = new IngredientList();

            meal.fromFile("data.txt");

            for (int i = 0; i < meal.Length; i++)
            {
                for (int j = 0; j < meal.mealList[i].ingredients.Count; j++)
                {
                    Ingredient temp = meal.mealList[i].ingredients[j];
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
    }
}
