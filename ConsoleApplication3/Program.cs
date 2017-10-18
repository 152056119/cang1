using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义类对象
            Calculator c = new Calculator();
            Boolean flag = true;
            while (flag)
            {
                //用户输入信息
                Console.WriteLine("请输入要计算的数字或字符串：");
                //读取用户的输入
                String a = Console.ReadLine();
                String b = Console.ReadLine();
                //选择要进行的运算
                Console.WriteLine("请进行你的选择：1 加法----2 减法----3 乘法----4 除法");
                int i = Convert.ToInt32(Console.ReadLine());
                //调用类函数进行运算并返回值
                switch (i)
                {
                    case 1:
                        //对输入的字符串进行判断
                        if (Regex.IsMatch(a, @"^[0-9]*$") || Regex.IsMatch(b , @"^[0-9]*$")) {
                           
                           Console.WriteLine(c.add(Convert.ToInt32(a), Convert.ToInt32(b)));
                        }
                        else
                            Console.WriteLine(c.add(a, b));
                        break;
                    case 2:
                        //对输入的字符串进行判断
                        if (Regex.IsMatch(a, @"^[0-9]*$") || Regex.IsMatch(b, @"^[0-9]*$"))
                        {
                           
                            Console.WriteLine(c.jian(Convert.ToInt32(a), Convert.ToInt32(b)));
                        }
                        else
                            Console.WriteLine(c.jian(a, b));
                        break;
                    case 3:
                        if (Regex.IsMatch(a, @"^[0-9]*$") || Regex.IsMatch(b, @"^[0-9]*$"))
                        {
                            Console.WriteLine(c.cheng(Convert.ToInt32(a), Convert.ToInt32(b)));
                        }
                        else
                            Console.WriteLine("请输入数字！");
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine(c.chu(Convert.ToInt32(a), Convert.ToInt32(b)));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("分母不能为0");
                            throw ex;

                        }

                        break;
                }
                //判断是否继续进行运算
                Console.WriteLine("请选择是否继续：Y-是，N-否");
                String s = Console.ReadLine();
                if (s.Equals("Y"))
                    flag = true;
                else if (s.Equals("N"))
                    flag = false;
                else
                    Console.WriteLine("输入有误");
            }

        }
    }
    class Calculator
    {
        //定义数字加法函数
        public int add(int a, int b)
        {

            return a + b;

        }
        //定义字符串加法函数
        public String add(String a, string b)
        {

            return a + b;
        }
        //定义数字减法函数
        public int jian(int a, int b)
        {
            return a - b;

        }
        //定义字符串减法函数
        public String jian(String a, String b)
        {
            string t = "";
            char[] str1 = a.ToCharArray();
            char[] str2 = b.ToCharArray();
            List<char> list = new List<char>();
            for (int k = 0; k < str1.Length; k++)
            {
                list.Add(str1[k]);
            }
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        list.Remove(str1[j]);
                    }
                }
            }
            foreach (char c in list)
            {
                t = t + c;
            }
            return t;
        }
        //定义乘法函数
        public int cheng(int a, int b)
        {
            return a * b;

        }
        //定义除法函数
        public int chu(int a, int b)
        {
            return a / b;

        }

    }
}


           
                        
                                        
                        
                  
                        
                        
                            
                                        
                                       
                                   
                                        
                                   
                       

                        
                       

                    



                            



                                

                                
                           
                        
                        
                            
                       
                           
                       
                    


                

            
           

           
            
            

        

        