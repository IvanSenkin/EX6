using System;
using System.Text;

namespace EX6
{
    public class Methods
    {
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
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
    }
}
