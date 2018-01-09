using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 笔记本终极版
{
    public partial class Form1 : Form
    {
        private int index = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入内容");
            }
            else
            {
                listBox2.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择内容");
            }
            else
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabPage Page = new TabPage();
            Page.Name = "Page" + index.ToString();
            Page.Text = textBox3.Text ;
            Page.TabIndex = index;
            this.tabControl3.Controls.Add(Page);
            this.tabControl3.SelectedTab = Page;
            index++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             bool first = true;  
            if (index > 0)  
            {                
                this.tabControl3.Controls.RemoveAt(this.tabControl3.SelectedIndex);  
            }  
            else  
            {  
                return;  
            }  
            if (first)  
            {  
                this.tabControl3.SelectedIndex = --index - 1;  
                first = false;  
            }  
            else  
            {  
                this.tabControl3.SelectedIndex = index--;  
            }  
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl3.SelectedTab.Text = textBox3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
             if (textBox2.Text == "")
            {
                MessageBox.Show("请输入内容");
            }
            else
            {
                listBox1.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择内容");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
