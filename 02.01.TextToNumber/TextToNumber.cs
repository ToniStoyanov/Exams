using System;
namespace _02._02.TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            int module = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            inputText = inputText.ToLower();
            long result = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                char ch = inputText[i];
                if (ch == '@')
                {
                    break;
                }
                else if (char.IsDigit(ch))
                {
                    result *= (ch - '0');
                }
                else if (char.IsLetter(ch))
                {
                    result += (ch - 'a');
                }
                else
                {
                    result %= module;
                }

            }
            Console.WriteLine(result);
        }
    }
}
