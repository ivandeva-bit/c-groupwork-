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
    public partial class frmDistance : Form
    {
        public frmDistance()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float speed;
            float time;
            float distance;
            if (float.TryParse(txtSpeed.Text, out speed))
            {
                if (float.TryParse(txtTime.Text, out time))
                {
                    distance = speed * time;
                    lblDistance.Text = $"Distance : {distance:f2} km";
                }
                else
                    MessageBox.Show("Invalid time");
            }
            else
                MessageBox.Show("Invalid speed");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeed.Clear();
            txtTime.Clear();
            lblDistance.Text = String.Empty;
            txtSpeed.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDistance_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
