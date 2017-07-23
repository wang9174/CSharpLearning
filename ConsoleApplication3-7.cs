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

            int a = 20;
            int b = 10;
            int c = 15;
            int d = 5;
            int e;
            e = (a + b) * c / d; // ( 30 * 15 ) / 5
            Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

            e = ((a + b) * c) / d; // (30 * 15 ) / 5
            Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

            e = (a + b) * (c / d); // (30) * (15/5)
            Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

            e = a + (b * c) / d; // 20 + (150/5)
            Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
            Console.ReadLine();

        }
    }
}