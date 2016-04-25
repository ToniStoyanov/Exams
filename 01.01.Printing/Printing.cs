using System;
namespace _01.Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double sheetsOfPaper = N * S;
            double reams = sheetsOfPaper / 500;

            Console.WriteLine("{0:F2}",reams * P);
        }
    }
}
