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
    public partial class CoockedMealsForm : Form
    {
        MealList coocked = new MealList();
        public CoockedMealsForm()
        {
            InitializeComponent();
            coocked.fromFile("CoockedData.txt");

            if(coocked.mealList != null)
            {
                listBox1.Items.AddRange(coocked.mealList.Select(n => n.name).ToArray());
                listBox2.Items.AddRange(coocked.mealList.Select(n => n.calories.ToString()).ToArray());
                listBox3.Items.AddRange(coocked.mealList.Select(n => n.weight.ToString()).ToArray());
                listBox4.Items.AddRange(coocked.mealList.Select(n => n.getListStr()).ToArray());
            }
            
        }
    }
}
