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
    public partial class person_information : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        string username="";
        public person_information()
        {
            InitializeComponent();
        }

        private void person_information_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from notepad_use where name='" + public_class.user_name + "'";
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                username = read["name"].ToString();
                textBox1.Text=username;
                textBox2.Text = read["password"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text t = new Text();
            this.Hide();
            t.Show();
        }

        private void button_modification_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !=username)
            {
                MessageBox.Show("不可改姓名");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Connection);
                conn.Open();
                string sqlinsert = "update notepad_use set password='" + textBox2.Text.Trim() + "' where name='"+username+"'";
                SqlCommand sc = new SqlCommand(sqlinsert, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("数据已经修改成功", "温馨提示");
                conn.Close();
            }
        }

        private void person_information_FormClosing(object sender, FormClosingEventArgs e)
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
