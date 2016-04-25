using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            int counter = 0;
            while (true)
            {
                int charCode = Console.Read();
                char ch = (char)charCode;
                if (ch == '@')
                {
                    break;
                }
                int newCode = 0;
                if (char.IsLetter(ch))
                {
                    newCode = charCode * salt + 1000;
                }
                else if (char.IsDigit(ch))
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0:F2}",newCode / 100.0);
                }
                else
                {
                    Console.WriteLine(newCode * 100);
                }
                counter++;
            }
        }
    }
}
