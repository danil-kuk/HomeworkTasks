
using System;
using System.Collections.Generic;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            var minNumber = FindLeastDifference();
            Console.WriteLine(minNumber);
        }

        static int FindLeastDifference()
        {
            var set = new HashSet<int>();
            for (int i = 1; i < 5000; i++)
            {
                for (int j = i + 1; j < 5000; j++)
                {
                    var firstNumber = MakePentagonalNumber(j);
                    var secondNumber = MakePentagonalNumber(i);
                    var numbersSubtract = firstNumber - secondNumber;
                    var numbersSum = firstNumber + secondNumber;
                    if (!set.Contains(firstNumber))
                        set.Add(firstNumber);
                    if (set.Contains(numbersSum) && set.Contains(numbersSubtract))
                        return numbersSubtract;
                }
            }
            return -1;
        }

        static int MakePentagonalNumber(int number) => number * (3 * number - 1) / 2;
    }
}
