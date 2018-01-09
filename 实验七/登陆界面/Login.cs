using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 登陆界面
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (UserName())
            {
                if (ErrorTimes() > 3)
                {
                    MessageBox.Show("登陆错误次数过多，禁止登陆！");
                    return;
                }
                if (PassWord())
                {
                    MessageBox.Show("登陆成功","",MessageBoxButtons.OK);
                    ResetErrorTimes();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    IntErrorTimes();
                    MessageBox.Show("登陆失败");
                }
            }
            else
            {
                MessageBox.Show("用户名不存在");
            }
        }
        //验证用户名是否存在
        private bool UserName()
        {
            string sql = "select count(*) from T_Users where UserName=@userName";
            SqlParameter[] pams = new SqlParameter[] { new SqlParameter("@userName", txtUserName.Text.Trim()) };
            int n = SQLHelper.ExecuteScalar(sql, pams);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //验证密码是否存在
        private bool PassWord()
        {
            string sql = "select count(*) from T_Users where Password=@password";
            SqlParameter[] pams = new SqlParameter[] { new SqlParameter("@password", txtPassword.Text.Trim()) };
            int n = SQLHelper.ExecuteScalar(sql, pams);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //读取错误次数
        private int ErrorTimes()
        {
            string sql = "select ErrorTimes from T_Users where UserName=@userName";
            SqlParameter[] pams = new SqlParameter[] { new SqlParameter("@userName", txtUserName.Text.Trim()) };
            int n = SQLHelper.ExecuteReader(sql, pams);
            return n;
        }
        //错误次数+1
        private void IntErrorTimes()
        {
            string sql = "update T_Users set ErrorTimes=ErrorTimes+1 where UserName=@userName";
            SqlParameter[] pams = new SqlParameter[] { new SqlParameter("@userName", txtUserName.Text.Trim()) };
            SQLHelper.ExecuteNonQuery(sql, pams);
        }
        //重置错误次数
        private void ResetErrorTimes()
        {
            string sql = "update T_Users set ErrorTimes=0 where UserName=@userName";
            SqlParameter[] pams = new SqlParameter[] { new SqlParameter("@userName", txtUserName.Text.Trim()) };
            SQLHelper.ExecuteNonQuery(sql, pams);
        }
    }
}