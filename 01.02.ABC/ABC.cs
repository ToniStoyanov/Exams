using System;

namespace _01._02.ABC
{
    class ABC
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(A,Math.Max(B,C)));
            Console.WriteLine(Math.Min(A,Math.Min(B,C)));
            Console.WriteLine("{0:F3}",(A+B+C)/3);
        }
    }
}
