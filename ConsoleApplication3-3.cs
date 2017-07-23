using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication2
{
   class Program
   {
     static void Main(string[] args)
     {
       //添加代码的地方
       int a = 12;
       int b = 23;
       Console.WriteLine("12+23=35");
       Console.WriteLine("{0}+{1}={2}",a, b, a+b);
       Console.WriteLine($"{a}+{b}={a +b}");
       Console.ReadKey();
       Console.ReadKey();
     }
   }
}