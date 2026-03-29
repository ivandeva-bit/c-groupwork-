using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2a
{
    public partial class Form2c : Form
    {
        public Form2c()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2c_Load(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void v1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);
            double length = double.Parse(textBox2.Text);
            double volume = Math.PI * radius * radius * length;
            textBox3.Text = volume.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void d1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox4.Text);
            int d1 = (number / 1000) % 10;
            int d2 = (number / 100) % 10;
            int d3 = (number / 10) % 10;
            int d4 = number % 10;
            int sum = d1 + d2 + d3 + d4;
            textBox5.Text = sum.ToString();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void f1_Click(object sender, EventArgs e)
        {
            double investment = double.Parse(inv.Text);
            double annual = double.Parse(air.Text);
            double year = double.Parse(years.Text);
            double monthly = annual /2 ;
            double future = Math.Pow(investment * (1 + monthly), year * 12);
            textBox9.Text = future.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
