using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook
{
    abstract class Message
    {
        public delegate void weituoDelegate();
        public event weituoDelegate weituo;
        public void weituo1()
        {
            weituo();
        }
        private string _TextName;
        protected string TextName
        {
            get { return _TextName; }
            set { _TextName = value; }
        }
        private string _TextBookName;
        protected string TextBookName
        {
            get { return _TextBookName; }
            set { _TextBookName = value; }
        }
        public abstract void Add(); //添加
        public abstract void Delete();//删除
        public abstract void Write();//输入
        public abstract void Read();//输出
    }
}
