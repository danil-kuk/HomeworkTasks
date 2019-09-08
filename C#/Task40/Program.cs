using System;
using System.Text;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersString = MakeNumbersString();
            var result = FindResult(numbersString);
            Console.WriteLine(result);
        }

        static int FindResult(StringBuilder numbersString)
        {
            // Операция " - '0' " нужна для получения int из char
            var result = numbersString[1] - '0';
            for (int i = 1; i < 7; i++)
            {
                result *= numbersString[(int)Math.Pow(10, i)] - '0';
            }
            return result;
        }

        static StringBuilder MakeNumbersString()
        {
            var numbersString = new StringBuilder();
            for (int i = 0; numbersString.Length <= 1000000; i++)
            {
                numbersString.Append(i);
            }
            return numbersString;
        }
    }
}
