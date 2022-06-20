using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork
{
    public partial class OrderMealForm : Form
    {
        MealList meals = new MealList();
        MealList coocked = new MealList();
        IngredientList products = new IngredientList();
        public OrderMealForm()
        {
            InitializeComponent();

            fillLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < meals.Length; i++)
            {
                
                if(meals.mealList[i].name == textBox1.Text)
                {
                    coocked.addItem(meals.mealList[i]);

                    foreach (var x in meals.mealList[i].ingredients)
                    {
                        listBox1.Items.Add(x.name);
                    }
                }
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Looks Like we haven't this item");
            }
        }

        private void fillLists()
        {
            meals.fromFile("data.txt");
            products.fromFile("IngredientData.txt");

            listBox2.Items.AddRange(products.Ingredients.Select(n => n.name).ToArray());
            listBox3.Items.AddRange(products.Ingredients.Select(n => n.count.ToString()).ToArray());
        }

        private void ConfirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("You cannot comfirm this order");
            }
            else
            {
                DialogResult res = MessageBox.Show($"Confirm your order {textBox1.Text}?",
                    "Order Confirmation", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    if (checkIngredients() == true)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            foreach (var j in listBox1.Items)
                            {
                                if (j.ToString() == products.Ingredients[i].name && products.Ingredients[i].count != 0)
                                {
                                    products.Ingredients[i].count--;
                                }
                            }
                        }
                        meals.toFile("data.txt");
                        products.toFile("IngredientData.txt");

                        listBox2.Items.Clear();
                        listBox3.Items.Clear();

                        fillLists();
                        coocked.addToFile("CoockedData.txt");
                    }
                    else
                    {
                        MessageBox.Show("You can't confirm this order, because of the lack of products");
                        coocked.mealList.RemoveAt(coocked.Length - 1);
                    }

                    
                }
                listBox1.Items.Clear();
                textBox1.Text = "";
            }
        }

        private bool checkIngredients()
        {
            int count = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                for(int j = 0; j < products.Length; j++)
                {
                    if (listBox1.Items[i].ToString() == products.Ingredients[j].name && products.Ingredients[j].count > 0)
                    {
                        count++;
                        break;
                    }
                }
                
            }

            return count == listBox1.Items.Count;

        }
    }
}
