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


            int a = 21;
            int c;

            c = a;
            Console.WriteLine("Line 1 - = c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -= c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *= c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /= c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %= c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<= c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>= c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &= c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^= c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |= c 的值 = {0}", c);
            Console.ReadLine();

        }
    }
}
