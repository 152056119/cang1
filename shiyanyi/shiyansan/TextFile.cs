using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace NoteBook
{
    class Textfile : Message
    {
        public override void Add()
        {
            Console.WriteLine("请输入要创建文件夹的名字：");
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName) == false)
                {
                    Directory.CreateDirectory(@"E:\C#\新建文件夹\" + TextName); //如果文件夹不存在，直接创建文件夹。
                    Console.WriteLine("成功");
                }
                else
                    if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName))
                    {
                        Console.WriteLine("{0}：文件夹已有！！", @"D:\C#程序\作业\" + TextName);
                    }
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
        public override void Delete()
        {
            Console.WriteLine("请输入要删除的文件夹名字：");
            TextName = Console.ReadLine();
            if (TextName.Length != 0)
            {
                if (Directory.Exists(@"E:\C#\新建文件夹\" + TextName)) //如果存在这个文件夹删除之 
                {
                    Directory.Delete(@"E:\C#\新建文件夹\" + TextName, true);
                    Console.WriteLine("成功！");
                }
                else
                    Console.WriteLine("{0}此文件夹不存在！", @"G:\C#练习\新建文件夹\" + TextName);
            }
            else
                Console.WriteLine("文件夹名字不能为空！！");
        }
        public override void Write()
        {
            throw new NotImplementedException();
        }
        public override void Read()
        {
            Console.WriteLine("已创建的文件夹如下：");
            foreach (string d in Directory.GetFileSystemEntries(@"E:\C#\新建文件夹\"))
            {
                Console.WriteLine(" " + d);
            }
        }
    }
}
