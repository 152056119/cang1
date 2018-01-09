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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string sql = "select * from T_Student";
        DataTable table = new DataTable();

        private void btnRead1_Click(object sender, EventArgs e)
        {
            table = SQLHelper.DataReader(sql, null);

            DataView view = new DataView(table);
            view.Sort = "Sno DESC,Sname";
            dataGridView1.DataSource = view;

        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            table = SQLHelper.DataSet(sql, null);

            DataView view = new DataView(table);
            view.RowFilter = "Ssex='男'";
            dataGridView2.DataSource = view;
        }
    }
}
