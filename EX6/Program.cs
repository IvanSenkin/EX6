using System;
public delegate double Fun(double x, double a);
class Program
{
    public static void Table(Fun F, double a ,double x, double b)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a)); 
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    public static double MyFunc1(double x, double a)
    {
        return a * x * x;
    }
    public static double MyFuncSin(double x, double a)
    {
        return a * Math.Sin(x);
    }

    static void Main()
    {
        Start();

    }

    private static void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Таблица a*x^2");
        Table(MyFunc1, 42, -2, 2);
        Console.WriteLine("Таблица функции a*Sin(x):");
        Table(MyFuncSin, 2, -2, 2);
    }
}

