using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled=false;
            pictureBox3.Image = Properties.Resources.c;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.a;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.b;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            pictureBox3.Image = Properties.Resources.d;
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
