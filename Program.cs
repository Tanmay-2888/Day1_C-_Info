using System;

namespace Day1_C__Info
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=10;
           float f=23.45f;
           double d= 56.677;
           string str ="Tanmay";
           System.Console.WriteLine("value of a ="+a);
           System.Console.WriteLine("value of f {0} , d={1}",f,d);
           System.Console.WriteLine($"a={a}, float ={f}, double={d}");
           System.Console.WriteLine(str);
        }
    }
}
