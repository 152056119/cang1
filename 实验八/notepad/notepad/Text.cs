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
using System.IO;


namespace notepad
{
    public partial class Text : Form
    {
        //读取配置文件:app.config
        string Connection = ConfigurationManager.ConnectionStrings["notepad.Properties.Settings.notepadConnectionString"].ConnectionString;
        public Text()
        {
            InitializeComponent();
        }

       
        private void save() {
            if (textBox1.Text == "")
            {
                MessageBox.Show("您没有填写任何内容，您是否想继续保存保存？");
            }
            else
            {
                string time = dateTimePicker1.Text.Trim();
                SqlConnection conn = new SqlConnection(Connection);
                conn.Open();
                string sqlinsert = "insert into notepad_content values('" + public_class.user_name.Trim() + "','" + comboBox_type.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + time + "')";//Convert.ToDateTime
                SqlCommand sc = new SqlCommand(sqlinsert, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("保存完成,记录生活的点点滴滴！！！");
                conn.Close();
                textBox1.Text = "";
            }
        
        }
        private void MenuItem_save_document_Click(object sender, EventArgs e)//保存文件
        {
            save();

        }
        bool b = false;
        private string txtName = "";
        bool s = true;
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //对话框提示标题文字。
            ofd.Title = "打开文本文档-Mxdr记事本";
            //过滤文件，只显示文本文档格式的文件。
            ofd.Filter = "文本文档|*.txt|所有文档|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //声明一个文件流对象，用来存放读取的文件流对象。
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                //将文件名赋值给临时变量。
                txtName = ofd.FileName;
                //创建读取器，用来将文件流中的数据读取出来。
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                //通过读取器将文件流中的数据读取到文本框中。
                textBox1.Text = sr.ReadToEnd();
                //关闭读取器。
                sr.Close();
                //和关闭文件流。
                fs.Close();
                //由于文件读取原理，上面两项关闭必须操作，否则无法成功读取文件。
            }
            this.Text = txtName + "-记事本";
            b = true;
            s = true;
        }
        private void Openthe()
        {
            if (s == true)
            {
                this.OpenFile();
            }
            else
            {
                this.save();
                this.OpenFile();
            }
           
        }

        private void MenuItem_clear_document_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void MenuItem_document_Click(object sender, EventArgs e)
        {

        }

        private void Text_Load(object sender, EventArgs e)
        {
            label_title.Text = "欢迎你使用：" + public_class.user_name;
        }

        private void MenuItem_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_information p = new person_information();
            this.Hide();
            p.Show();
        }

        private void 查看保存文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document_information di = new Document_information();
            this.Hide();
            di.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Text_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //字体
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            { this.textBox1.Font = font.Font; }
        }

  
       

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Openthe();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            textBox1.SelectionColor = colorDialog1.Color;
        }

        private void 文本背景toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            文本背景toolStripMenuItem5.Checked = true;
        }

        private void 工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 剪切toolStripButton1_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void 复制toolStripButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void 粘贴toolStripButton3_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void 工具栏toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Point point;
            if (工具栏toolStripMenuItem5.Checked != true)
            {
                // 隐藏工具栏时，把坐标设为（0，24）,因为菜单的高度为24
                point = new Point(0, 24);
                工具栏toolStripMenuItem5.Checked = false;
                toolStrip1.Visible = false;
                textBox1.Location = point;
                textBox1.Height += toolStrip1.Height;
            }
            else
            {
                /* 显示工具栏时，多格式文本框左上角位置的位置为（0，49），
                 *  因为工具栏的高度为25，加上菜单的高度24后为49                  
                 */
                point = new Point(0, 49);
                工具栏toolStripMenuItem5.Checked = true;
                toolStrip1.Visible = true;
                textBox1.Location = point;
                textBox1.Height -= toolStrip1.Height;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void 左对齐toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (左对齐toolStripMenuItem5.Checked == false)
            {
                this.textBox1.SelectionAlignment = HorizontalAlignment.Left;
                左对齐toolStripMenuItem5.Checked = true;
                居中toolStripMenuItem5.Checked = false;
                右对齐toolStripMenuItem6.Checked = false;
            }
        }

        private void 右对齐toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (右对齐toolStripMenuItem6.Checked == false)
            {
                this.textBox1.SelectionAlignment = HorizontalAlignment.Right;
                左对齐toolStripMenuItem5.Checked = false;
                居中toolStripMenuItem5.Checked = false;
                右对齐toolStripMenuItem6.Checked = true;
            }
        }

        private void 居中toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (居中toolStripMenuItem5.Checked == false)
            {
                this.textBox1.SelectionAlignment = HorizontalAlignment.Center;
                左对齐toolStripMenuItem5.Checked = false;
                居中toolStripMenuItem5.Checked = true;
                右对齐toolStripMenuItem6.Checked = false;
            }
        }

       
       
       
    }
}
