using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Convert;
using System.Threading.Tasks;
//声明区


namespace ConsoleApplication1
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


            //int myInteger; //4.1布尔运算符
            //string myString;
            //myInteger = 666;
            //myString = "\"myIneger\" is ";
            //Console.WriteLine($"{ myString}{ myInteger}");
            //Console.ReadKey();


            //string myVal = "wang";
            //bool myString;
            //myString = myVal =="Wang"; //当使用<>进行比较时会报错
            //Console.WriteLine(myString );
            //Console.ReadKey();

            //string comparison;  //4.2 if语句实例
            //WriteLine("Enter a Number:");
            //double var1 = ToDouble(ReadLine());
            //WriteLine("Enter another Number:");
            //double var2 = ToDouble(ReadLine());
            //if (var1 < var2)
            //    comparison = "less than";
            //else
            //{
            //    if (var1 == var2)
            //        comparison = "equal to";
            //    else
            //        comparison = "greater than";
            //}
            //WriteLine($"The first number is {comparison} the second number");
            //ReadKey();

            //const string myName = "benjaming"; //4.2 swich语句实例
            //const string niceName = "andrea";
            //const string sillyName = "ploppy";
            //string name;
            //WriteLine("What is your name?");
            //name = ReadLine();
            //switch (name.ToLower())
            //{
            //    case myName:
            //        WriteLine("you have the same name as me!");
            //        break;
            //    case niceName:
            //        WriteLine("what a nice name you have!");
            //        break;
            //    case sillyName:
            //        WriteLine("That's a very silly name.");
            //        break;
            //}
            //WriteLine($"Hello,{name}!");
            //ReadKey();
            #endregion

            int i = 1; //4.3 do循环
            do
            {
                WriteLine("{0}", i++);
            } while (i <= 10);

            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine(@"What is your current interest rate(in %)?");
            interestRate = ToDouble(ReadLine()) / 100.0 + 1;
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYear = 0;
            do
            {
                balance *= interestRate;
                ++totalYear;
            }
            while (balance < targetBalance);
            WriteLine($"In {totalYear} year{(totalYear == 1 ? "" : "s")} you'll have a balance of {balance }.");
            ReadKey();



        }
    }
}
