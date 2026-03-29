using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2a
{
    public partial class Form2b : Form
    {
        public Form2b()
        {
            InitializeComponent();
        }

        private void Form2b_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int d1 = number / 10000;
            int d2 = (number / 1000) % 10;
            int d3 = (number / 100) % 10;
            int d4 = (number / 10) % 10;
            int d5 = number % 10;
            digit1.Text = d1.ToString();
            digit2.Text = d2.ToString();
            digit3.Text = d3.ToString();
            digit4.Text = d4.ToString();
            digit5.Text = d5.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
