using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 登陆界面
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login frmlogin = new Login();
            DialogResult result = frmlogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                frmMain frmmain = new frmMain();
                Application.Run(frmmain);
            }
        }
    }
}
