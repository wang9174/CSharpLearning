using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//声明区


namespace ConsoleApplication2
{
    //枚举，结构定义区
    class Program
    {
        //定义函数区
        static void Main(string[] args)
        {
            //添加代码的地方
            #region 
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();


            //int a = 12;
            //int b = 23;
            //Console.WriteLine("12+23=35");
            //Console.WriteLine("{0}+{1}={2}", a, b, a+b);
            //Console.WriteLine($"{a}+{b}={a + b}");
            //Console.ReadKey();
            #endregion

            int myInteger;
            string myString;
            myInteger = 666;
            myString = "\"myIneger\" is ";
            Console.WriteLine($"{ myString}{ myInteger}");
            Console.ReadKey();

            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1 - c 的值是 {0}", c);
            c = a - b;
            Console.WriteLine("Line 2- c 的值是 { 0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            // ++a 先进行自增运算再赋值
            c = ++a;
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            // 此时 a 的值为 22
            // --a 先进行自减运算再赋值
            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);
            Console.ReadLine();

        }
    }
}