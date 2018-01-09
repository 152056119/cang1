using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace NoteBook
{
    class Text : Message
    {
        public override void Add()
        {
            Console.WriteLine("请选择要把新建笔记放入以下哪个文件夹中：");
            foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName))
                {
                    Console.WriteLine("请输入要创建文件的名字：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (!File.Exists(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt"))
                        {
                            FileStream fs1 = File.Create(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt");
                            Console.WriteLine("成功,文件名叫：{0}", TextName + ".txt");
                            fs1.Close();
                        }
                        else
                            Console.WriteLine("失败,已存在文件名为：{0}的文件！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Delete()
        {
            Console.WriteLine("请选择要删除哪个文件夹下的笔记：");
            foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\" + TextName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    Console.WriteLine("请输入要删除文件的名字：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt"))
                        {
                            File.Delete(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt");
                            Console.WriteLine("成功，删除的文件名叫：{0}", TextName + ".txt");
                        }
                        else
                            Console.WriteLine("失败,{0}的文件不存在！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Read()
        {
            Console.WriteLine("请选择要打开以下哪个文件夹中的笔记：");
            foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\" + TextName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    Console.WriteLine("请输入要操作的文件名：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt"))
                        {
                            Console.WriteLine(System.IO.File.ReadAllText(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt", Encoding.Default));
                            Console.WriteLine("成功！");
                        }
                        else
                            Console.WriteLine("错误！{0}文件不存在", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }

        public override void Write()
        {
            Console.WriteLine("请选择要在哪个文件夹下输入笔记：：");
            foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName))
                {
                    Console.WriteLine("有以下文件：");
                    foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\" + TextName + "\\"))
                    {
                        Console.WriteLine(" " + d);
                    }
                    string ss;
                    Console.WriteLine("请输入要操作的文件名：");
                    TextName = Console.ReadLine();
                    if (TextName.Length != 0)
                    {
                        if (File.Exists(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt"))
                        {
                            Console.WriteLine("请输入需要输入的信息：");
                            ss = Console.ReadLine();
                            File.AppendAllText(@"E:\C#\新建文件夹\" + TextName + "\\" + TextName + ".txt", ss, Encoding.Default);//可在文本后面加字符串
                            Console.WriteLine("成功！");
                        }
                        else
                            Console.WriteLine("{0}文件不存在，请新建！", TextName + ".txt");
                    }
                    else
                        Console.WriteLine("笔记名字不能为空！！");
                }
                else
                    Console.WriteLine("失败！没有该文件：{0}", TextName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
    }
}
