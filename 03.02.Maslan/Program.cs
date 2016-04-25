using System;
using System.Numerics;
namespace _03._01.SaddyCoper
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int counter = 0;
            while (number.Length > 1 && counter < 10)
            {
                BigInteger result = 1;
                while (number.Length > 0)
                {
                    number = number.Substring(0, number.Length - 1);
                    int sum = 0;
                    for (int i = 1; i < number.Length; i += 2)
                    {
                        sum += (number[i] - '0');
                    }

                    if (sum != 0)
                    {
                        result *= sum;
                    }
                }
                counter++;
                number = result.ToString();
            }
            if (counter < 10)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine(number);



        }
    }
}