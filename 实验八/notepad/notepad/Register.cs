using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//连接数据库所用的头文件
//添加引用system.configuration
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;


namespace notepad
{
    public partial class Register : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        public Register()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Regex password = new Regex("^[a-zA-Z0-9]+$");
            if (textBox1.Text == "")
            {
                MessageBox.Show("姓名不许为空");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("密码不许为空");
                }
                else
                {
                    //string text=textBox2.Text.Trim();
                    if (password.IsMatch(textBox2.Text.Trim()))
                    {
                        SqlConnection conn = new SqlConnection(Connection);
                        conn.Open();
                        string sqlinsert = "insert into notepad_use values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";
                        SqlCommand sc = new SqlCommand(sqlinsert, conn);
                        sc.ExecuteNonQuery();
                        MessageBox.Show("注册完成");
                        conn.Close();
                        Login l = new Login();
                        this.Hide();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("只能输入字母和数字");

                    }


                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
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

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    if (System.Text.RegularExpressions.Regex.IsMatch("^[a-zA-Z0-9]+$", textBox2.Text))
        //    {
        //        MessageBox.Show("只能输入字母和数字");
                
        //    }
        //}
    }
}
