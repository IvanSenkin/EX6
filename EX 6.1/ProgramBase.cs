using System;

namespace DoubleBinary
{
    internal class ProgramBase
    {

       public static void Start()
        {
            while (true)
            {
                Console.WriteLine("1 - x * x - 50 * x + 10 \n2- Math.Sin(x)");
                int v = int.Parse(Console.ReadLine());
                Program.SaveFunc("data.bin", -100, 100, 0.5, v);
                Console.WriteLine(Program.Load("data.bin"));
                Console.ReadKey();
            }
        }
    }
}