using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Version1._0
{
    public class NoteBook
    {
        string _title;//标题
        string _content;//内容
        DateTime _time;//创建时间
        int _category;//类别
        string _name;//创建者名字

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        class Program
        {

            static void Main(string[] args)
            {
                SqlConnection conn = new SqlConnection();
                string connstr = "Data Source=FEI;Initial Catalog=NoteBook;Integrated Security=True";
                conn.ConnectionString = connstr;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;

                NoteBook notebook = new NoteBook();
                notebook = null;

                while (true)
                {
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("*                                       *");
                    Console.WriteLine("*   1：新建笔记          2：打开笔记     *");
                    Console.WriteLine("*   3：新建分类          4：管理分类     *");
                    Console.WriteLine("*   5：保存笔记          6：退出         *");
                    Console.WriteLine("*                                       *");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("请输入菜单选项(1-6);");

                    int option = Int32.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("*          1：新建笔记          *");
                            NoteBook notebook1 = new NoteBook();

                            //笔记本名称
                            Console.WriteLine("请输入笔记名称:");
                            string title = Console.ReadLine();
                            notebook1.Title = title;

                            //笔记创建时间
                            notebook1.Time = DateTime.Now;

                            //创建者名字
                            Console.WriteLine("请输入创建者名字:");
                            string name = Console.ReadLine();
                            notebook1.Name = name;

                            //笔记类别
                            Console.WriteLine("请输入笔记类别:");
                            string category = Console.ReadLine();
                            notebook1.Category = Int32.Parse(category);

                            //笔记内容
                            Console.WriteLine("请输入笔记内容:");
                            string content = Console.ReadLine();
                            notebook1.Content = content;
                            notebook = notebook1;

                            comm.CommandText = "insert into note values ('" + notebook1.Title + "','" + notebook1.Name
                                + "','" + notebook1.Time + "','" + notebook1.Category + "','" + notebook1.Content + "')";
                            comm.ExecuteNonQuery();
                            Console.WriteLine("创建成功");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("*          2：打开笔记         *");
                            comm.CommandText = "select * from note";
                            SqlDataReader sdr = comm.ExecuteReader();
                            if (sdr == null)
                            {
                                Console.WriteLine("没有笔记，请创建笔记");
                            }
                            else
                            {

                                while (sdr.Read())
                                {
                                    Console.WriteLine("笔记名称：{0}", sdr["title"]);
                                    Console.WriteLine("创建时间：{0}", sdr["time"]);
                                    Console.WriteLine("创建者名字：{0}", sdr["name"]);
                                    Console.WriteLine("笔记类别：{0}", sdr["category"]);
                                    Console.WriteLine("笔记内容：{0}", sdr["content"]);
                                }
                                sdr.Close();
                            }
                            Console.Clear();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("*          3：新建分类          *");
                            NoteBook showNote1 = new NoteBook();
                            showNote1 = notebook;
                            comm.CommandText = "select classname from classify where category = " + showNote1.Category;
                            string classname = (string)comm.ExecuteScalar();
                            Console.WriteLine("该笔记当前所在分类为：" + classname);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("*           4：管理分类            *");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("*           5：保存笔记            *");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("退出");

                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("输入错误,请重新输入");
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                }
                conn.Close();
            }
        }
    }
}
