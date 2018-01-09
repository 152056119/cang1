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

namespace notepad
{
    public partial class Login : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        //定义用户名和密码
        string username ="";
        string password ="";

        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection);//用户登录查找
            conn.Open();//打开数据库
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from notepad_use where name='" + textBox1.Text.Trim() + "'";
            SqlDataReader read = cmd.ExecuteReader();
            
            if (read.Read())
            {
                username = read["name"].ToString();
                password = read["password"].ToString();

            }
            conn.Close();
            if (textBox1.Text == username.Trim() && textBox2.Text == password.Trim())
            {
                public_class.user_name = username;
                //SqlConnection connlogin = new SqlConnection(Connection);
                //connlogin.Open();
                conn.Open();
                string time = DateTime.Now.ToString();
                string sqlinsert = "insert into notepad_login values('" + textBox1.Text.Trim() + "','" + time + "')";
                SqlCommand sc = new SqlCommand(sqlinsert, conn);
                sc.ExecuteNonQuery();
                conn.Close();
                //connlogin.Close();
                this.Hide();
                Text t = new Text();
                
                t.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码输入错误");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
