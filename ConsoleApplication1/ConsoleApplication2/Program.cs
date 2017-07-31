﻿using System;
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

    //enum orientation : byte
    //{
    //    north = 1,
    //    south = 2,
    //    east = 3,
    //    west = 4
    //}

    //struct route
    //{
    //    public orientation direction;
    //    public Double distance;
    //}
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

            //int i = 1; //4.3 do循环
            //do
            //{
            //    WriteLine("{0}", i++);
            //} while (i <= 10);

            //double balance, interestRate, targetBalance;
            //WriteLine("What is your current balance?");
            //balance = ToDouble(ReadLine());
            //WriteLine(@"What is your current interest rate(in %)?");
            //interestRate = ToDouble(ReadLine()) / 100.0 + 1;
            //WriteLine("What balance would you like to have?");
            //targetBalance = ToDouble(ReadLine());
            //int totalYear = 0;
            //do
            //{
            //    balance *= interestRate;
            //    ++totalYear;
            //}
            //while (balance < targetBalance);
            //WriteLine($"In {totalYear} year{(totalYear == 1 ? "" : "s")} you'll have a balance of {balance }.");
            //ReadKey();

            //int numbertwo, numberone; //4.3 do循环判定用户输入
            //do
            //{
            //    WriteLine("Please enter the first number:");
            //    numberone = ToInt32(ReadLine());
            //    WriteLine("Please enter the second number:");
            //    numbertwo = ToInt32(ReadLine());
            //    if (numberone > 10 & numbertwo > 10)
            //        WriteLine($"The first number you enter is {numberone },the second number you enter is{numbertwo }." +
            //            "It's not allowed that both of the two number greater than 10, please try again!");
            //} while (numberone > 10 & numbertwo > 10);
            //WriteLine($"The first number you enter is {numberone },the second number you enter is {numbertwo }.");
            //ReadKey();


            //short shortrResult, shortVal = 4; //5.1 类型转换
            //int integerVal = 67;
            //long longResult;
            //float floatVal = 10.5F;
            //double doubleResult, doubleVal = 99.999;
            //string stringResult, stringVal = "17";
            //bool boolVal = true;
            //WriteLine("Variable Conversion Examples\n");
            //doubleResult = floatVal * shortVal;
            //WriteLine($"Implicit,-> double: {floatVal } * {shortVal } -> {doubleResult }");
            //shortrResult = (short)floatVal;
            //WriteLine($"Explicit,-> short: {floatVal} -> {shortrResult }");
            //stringResult = Convert.ToString(boolVal) +
            //    Convert.ToString(doubleVal);
            //WriteLine($"Explicit, -> string: \"{boolVal }\" + \"{doubleVal }\" -> " +
            //    $"{stringResult }");
            //longResult = integerVal + ToInt32(stringVal);
            //WriteLine($"mixed, -> long: {integerVal } + {stringVal } -> {longResult }");
            //ReadKey();


            //orientation myDirction = orientation.north; //5.2 使用枚举
            //WriteLine($"MyDriction is {myDirction }");
            //ReadKey();


            //route myRoute; //5.2.2 使用结构
            //int myDirection = -1;
            //double myDistance;
            //WriteLine("1) North \n2) South \n3) East \n4) West");
            //do
            //{
            //    WriteLine("Select a direction");
            //    myDirection = ToInt32(ReadLine());
            //} while (myDirection < 1 | myDirection > 4);
            //WriteLine("Input a distance:");
            //myDistance = ToDouble(ReadLine());
            //myRoute.direction = (orientation)myDirection;
            //myRoute.distance = myDistance;
            //WriteLine($"myRoute specifies a direction of {myRoute.direction} " +
            //    $"and a distance of {myRoute.distance}");
            //ReadKey();


            //string[] friendName = { "Today", "Hotel", "Shine" }; //5.2.3 使用数组
            //int i;
            //WriteLine($"Here are {friendName.Length} of your friendName");
            //for (i = 0; i < friendName.Length; i++)
            //{
            //    WriteLine(friendName[i]);
            //}
            //ReadKey();


            //string[] friendName = new string[3] { "Hosptal", "Hotel", "Captaion" };  //5.2.3 foreach循环
            //foreach (string name in friendName)
            //{
            //    WriteLine(name);
            //}

            //double[,] hillHeight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };  //5.2.3 多维数组
            //foreach (double high in hillHeight)
            //{
            //    WriteLine("{0}", high);
            //}
            //ReadKey();


            //int[][] divisors1To10 = { new int[] { 1, 2 }, new int[] { 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8 }, new int[] { 9 } }; //5.2.3 数组的数组
            //foreach (int[] divisor in divisors1To10)
            //{
            //    foreach (int div in divisor)
            //    {
            //        WriteLine(div);
            //    }
            //}
            //ReadKey();


            //string mystring = "A string"; //5.3 字符串是字符的只读数组
            //for (int i = 0; i < mystring.Length; i++)
            //{
            //    WriteLine(mystring[i]);
            //}
            //ReadKey();
            #endregion

            string mystring = "This is a test."; //5.3 字符串的拆分
            char[] separator = { ' ' };
            string[] myWord;
            myWord = mystring.Split(separator);
            foreach (string word in myWord)
            {
                WriteLine($"{word}");
            }
            ReadKey();



        }
    }
}
