using System;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindСoefficientСomposition();
            Console.WriteLine(result);
        }

        static int FindСoefficientСomposition()
        {
            var maxSequenceLength = 0;
            var result = 0;
            for (int a = -999; a < 1000; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    var primeNumbersCount = CheckEquation(a, b);
                    if (primeNumbersCount > maxSequenceLength)
                    {
                        maxSequenceLength = primeNumbersCount;
                        result = a * b;
                    }
                }
            }
            return result;
        }

        static int CheckEquation(int a, int b)
        {
            for (int n = 0;  ; n++)
            {
                if (!IsPrimeNumber(n * n + n * a + b))
                    return n - 1;
            }
        }

        static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
