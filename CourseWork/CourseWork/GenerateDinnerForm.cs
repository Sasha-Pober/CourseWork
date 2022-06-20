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
    public partial class GenerateDinnerForm : Form
    {
        MealList meal = new MealList();

        MealList first = new MealList();
        MealList second = new MealList();
        MealList dessert = new MealList();


        Random r = new Random();
        public GenerateDinnerForm()
        {
            InitializeComponent();
            createMealList();
        }

        private void createMealList()
        {
            meal.fromFile("data.txt");
        }

        private void FormLists()
        {
            foreach (var i in meal.mealList)
            {
                if (i.rate == "first")
                {
                    first.addItem(i);
                }
                else if (i.rate == "second")
                {
                    second.addItem(i);
                }
                else if (i.rate == "dessert")
                {
                    dessert.addItem(i);
                }
            }
        }

        private void FormLists(string name)
        {
            foreach (var i in meal.mealList)
            {
                if (i.type == name)
                {
                    if (i.rate == "first")
                    {
                        first.addItem(i);
                    }
                    else if (i.rate == "second")
                    {
                        second.addItem(i);
                    }
                    else if (i.rate == "dessert")
                    {
                        dessert.addItem(i);
                    }
                }
            }
        }

        private void clearLists()
        {
            first.mealList.Clear();
            second.mealList.Clear();
            dessert.mealList.Clear();
        }

        private void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
                 
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void generate()
        {
            clearTextBoxes();
            FormLists();

            if (first.Length != 0)
            {
                Dish firstDish = first.mealList[r.Next(0, first.Length - 1)];

                textBox1.Text = firstDish.name;
                textBox2.Text = firstDish.calories.ToString();
                textBox3.Text = firstDish.weight.ToString();
                textBox4.Text = firstDish.getListStr();
            }
            if (second.Length != 0)
            {
                Dish secondDish = second.mealList[r.Next(0, second.Length - 1)];

                textBox5.Text = secondDish.name;
                textBox6.Text = secondDish.calories.ToString();
                textBox7.Text = secondDish.weight.ToString();
                textBox8.Text = secondDish.getListStr();
            }
            if (dessert.Length != 0)
            {
                Dish dessertDish = dessert.mealList[r.Next(0, dessert.Length - 1)];

                textBox9.Text = dessertDish.name;
                textBox10.Text = dessertDish.calories.ToString();
                textBox11.Text = dessertDish.weight.ToString();
                textBox12.Text = dessertDish.getListStr();
            }

            clearLists();
        }

        private void generate(string name)
        {
            clearTextBoxes();
            FormLists(name);

            
            if (first.Length != 0)
            {
                Dish firstDish = first.mealList[r.Next(0, first.Length - 1)];

                textBox1.Text = firstDish.name;
                textBox2.Text = firstDish.calories.ToString();
                textBox3.Text = firstDish.weight.ToString();
                textBox4.Text = firstDish.getListStr();
            }
            if (second.Length != 0)
            {
                Dish secondDish = second.mealList[r.Next(0, second.Length - 1)];

                textBox5.Text = secondDish.name;
                textBox6.Text = secondDish.calories.ToString();
                textBox7.Text = secondDish.weight.ToString();
                textBox8.Text = secondDish.getListStr();
            }
            if (dessert.Length != 0)
            {
                Dish dessertDish = dessert.mealList[r.Next(0, dessert.Length - 1)];

                textBox9.Text = dessertDish.name;
                textBox10.Text = dessertDish.calories.ToString();
                textBox11.Text = dessertDish.weight.ToString();
                textBox12.Text = dessertDish.getListStr();
            }
            clearLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                generate();
            }

            if(radioButton2.Checked)
            {
                generate(radioButton2.Text);
            }

            if (radioButton3.Checked)
            {
                generate(radioButton3.Text);
            }

            if (radioButton4.Checked)
            {
                generate(radioButton4.Text);
            }
        }
    }
}
