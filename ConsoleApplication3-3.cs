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
        int myInteger;
        string myString;
        myInteger = 666;
        myString = "\"myIneger\" is ";
        Console.WriteLine($"{ myString}{ myInteger}");
        Console.ReadKey();
     }
   }
}