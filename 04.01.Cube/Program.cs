using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01.Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fieldSize = (n * 2) - 1;
            int mid = n - 1;
            char edge = ':';
            char empty = ' ';
            char slash = '/';
            char X = 'X';

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (row >= mid && col == 0 ||
                        row >= mid && col == mid ||
                        col == fieldSize - 1 && row <= mid ||
                        row == fieldSize - 1 && col <= mid ||
                        row == mid && col <= mid ||
                        row == 0 && col >= mid ||
                        row + col == mid ||
                        row + col == fieldSize - 1 + mid ||
                        row + col == fieldSize - 1 && col >= mid)
                    {
                        Console.Write(edge);
                    }
                    else if (col > mid && row + col <= fieldSize - 1 + mid && row + col >= fieldSize - 1)
                    {
                        Console.Write(X);
                    }
                    else if (row < mid && row + col >= mid)
                    {
                        Console.Write(slash);
                    }
                    else
                    {
                        Console.Write(empty);
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
