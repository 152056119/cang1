using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_Load(object sender, EventArgs e)
        {
            textBox1.Text = public_class.text_content;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document_information d = new Document_information();
            this.Hide();
            d.Show();
        }

        private void Open_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("确定要退出程序?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            } 
        }

    }
}
