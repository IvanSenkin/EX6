using System;
using System.IO;
public delegate double Fun1(double x); 
namespace DoubleBinary
{
    class Program : ProgramBase
    {
        public static double F1(double x) 
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return Math.Sin(x);
        }
       
        public static double F0(Fun1 F, double x) // создаю метод, который будет использовать делегат, получается в этот метож можно засунуть любой другой метод с той же сигнатурой.
        {           
            return F(x);
        }
        public static void SaveFunc(string fileName, double a, double b, double h, int v) // v - вариант
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            switch (v)
            {
                case 1:
                        while (x <= b)
                        {
                            bw.Write(F0(F1, x));  // исполльзую делегат для метода F1
                            x += h;// x=x+h;
                        }
                        bw.Close();
                        fs.Close();

                    break;
                case 2:
                        while (x <= b)
                        {
                             bw.Write(F0(F2, x));  // исполльзую делегат для метода F2
                        x += h;// x=x+h;
                        }
                        bw.Close();
                        fs.Close();

            break;

            }
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Start();
        }
    }
}

