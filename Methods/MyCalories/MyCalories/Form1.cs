using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var food = textBox1.Text;
            //var amaunt = int.Parse(textBox2.Text);

           // label1.Text = (loadFoods.foods[food].foodCaloriesPer1g * amaunt).ToString();
           // label2.Text = (loadFoods.foods[food].fatsPer1g * amaunt).ToString();
           // label3.Text = (loadFoods.foods[food].proteinPer1G * amaunt).ToString();
           // label4.Text = (loadFoods.foods[food].carbohydratesPer1g * amaunt).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        private void removeFood_Click(object sender, EventArgs e)
        {
            if (ateFoods.SelectedIndex >= 0)
            {
                ateFoods.Items.RemoveAt(ateFoods.SelectedIndex);
            }
            else
                MessageBox.Show("Please select any food");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Search foods....")
            {
                textBox1.Text = "";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foodForAdd.Items.Clear();
            if(e.KeyChar == 13)
            {

                var food = textBox1.Text;
                Dictionary<string,Food> results = loadFoods.foods.Where(x => x.Key.Contains(food)).ToDictionary(y => y.Key, y=> y.Value);
                
                foreach (var kvp in results)
                {
                    foodForAdd.Items.Add(kvp.Value.foodName);
                }
            }
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            var food = foodForAdd.SelectedItem.ToString();
            var fdCalories = loadFoods.foods[food].foodCaloriesPer1g * int.Parse(textBox2.Text);
            var fdFats = loadFoods.foods[food].fatsPer1g * int.Parse(textBox2.Text);
            var fdProtein = loadFoods.foods[food].proteinPer1G * int.Parse(textBox2.Text);
            var fdCarbs = loadFoods.foods[food].carbohydratesPer1g * int.Parse(textBox2.Text);



            if (foodForAdd.SelectedItem != null)
            {
                ateFoods.Items.Add(foodForAdd.SelectedItem + " - " + textBox2.Text +"g" + $"  ({fdCalories} calories / {fdFats} fats / {fdProtein} protein / {fdCarbs} carbs)");


            }
            else
                MessageBox.Show("Nothing selected");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
