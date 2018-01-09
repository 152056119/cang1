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
    public partial class Document_information : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        public Document_information()
        {
            InitializeComponent();
        }

        private void Document_information_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            string sqlinsert = "select * from notepad_content where name='" + public_class.user_name.Trim() + "'";
            //SqlCommand sc = new SqlCommand(sqlinsert, conn);
            //read.SelectCommand =sc;
            SqlDataAdapter read = new SqlDataAdapter(sqlinsert, conn);
            conn.Close();
            DataSet table = new DataSet();
            read.Fill(table);
            dataGridView1.DataSource = table.Tables[0];
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            string sqlinsert = "select * from notepad_content where 1=1 ";
            sqlinsert += " and name like '"+public_class.user_name.Trim()+"%'";
            sqlinsert += " and content_type like '" + comboBox_t.Text.Trim() + "%'";
            sqlinsert += " and contentbox like '" + textBox3.Text.Trim() + "%'";
            sqlinsert += " and content_time like '" + textBox1.Text.Trim() + "%'";
            
            
            //SqlDataAdapter read = new SqlDataAdapter(sqlinsert, conn);
            //conn.Close();
            //DataSet table = new DataSet();
            //read.Fill(table);
            //dataGridView1.DataSource = table.Tables[0];
            SqlCommand sc = new SqlCommand(sqlinsert, conn);
            SqlDataReader read = sc.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            
        }

        public void query()
        {
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            string sqlinsert = "select * from notepad_content where name='" + public_class.user_name.Trim() + "'";
            SqlDataAdapter read = new SqlDataAdapter(sqlinsert, conn);
            conn.Close();
            DataSet table = new DataSet();
            read.Fill(table);
            dataGridView1.DataSource = table.Tables[0];
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            string sqlinsert = "delete from notepad_content where ID='" + id+"'";
            SqlCommand sc = new SqlCommand(sqlinsert, conn);
            sc.ExecuteNonQuery();
            MessageBox.Show("删除完成");
            query();
            conn.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Text t = new Text();
            this.Hide();
            t.Show();
        }

        private void button_modification_Click(object sender, EventArgs e)
        {
            //string time = dateTimePicker1.Text.Trim();
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            SqlConnection conn = new SqlConnection(Connection);
            conn.Open();
            string sqlinsert = "update notepad_content set content_type='" + comboBox_t.Text.Trim() + "',contentbox='" + textBox3.Text.Trim() + "',content_time='" + textBox1.Text.Trim() + "' where ID='" + id + "'";
            SqlCommand sc = new SqlCommand(sqlinsert, conn);
            sc.ExecuteNonQuery();
            MessageBox.Show("数据已经修改成功", "温馨提示");
            query();
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (e.RowIndex > -1)
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                public_class.text_content = textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                comboBox_t.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
            //SqlConnection conn = new SqlConnection(Connection);
            //conn.Open();
            //string sqlinsert = "select * from notepad_content where name='" + public_class.user_name.Trim() + "'";
            //SqlCommand sc = new SqlCommand(sqlinsert, conn);
            //SqlDataAdapter read = new SqlDataAdapter(sqlinsert, conn);
            //conn.Close();
            //DataSet table = new DataSet();
            //read.Fill(table);
            //dataGridView1.DataSource = table.Tables[0];
            //SqlDataReader read = sc.ExecuteReader();
            //if (read.Read())
            //{
            //    comboBox_t.Text = read["content_type"].ToString();
            //    textBox3.Text = read["contentbox"].ToString();
            //    textBox1.Text = read["content_time"].ToString();

            //}
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void button_open_Click_1(object sender, EventArgs e)
        {
            Open o = new Open();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_t.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void Document_information_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Open o = new Open();
            this.Hide();
            o.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Open o = new Open();
            this.Hide();
            o.Show();
        }


        
    }
}
