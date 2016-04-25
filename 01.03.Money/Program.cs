using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine()); // Студенти
            double S = double.Parse(Console.ReadLine()); // Листи за 1 студент
            double P = double.Parse(Console.ReadLine()); // Цена

            double sheetsOfPaper = N * S;
            double reams = sheetsOfPaper / 400;
            Console.WriteLine("{0:0.000}", reams * P);
        }
    }
}
