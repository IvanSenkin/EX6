using System;
using EX6;
internal class ProgramBase
{
    public static void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Таблица a*x^2");
        Methods.Table(Methods.MyFunc1, 42, -2, 2);
        Console.WriteLine("Таблица функции a*Sin(x):");
        Methods.Table(Methods.MyFuncSin, 2, -2, 2);
    }
}