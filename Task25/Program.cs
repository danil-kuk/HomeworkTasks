using System;
using System.Collections.Generic;
using System.Numerics;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger prev = 0;
            BigInteger current = 1;
            var index = 1;
            while (current.ToString().Length != 1000)
            {
                var temp = current;
                current = prev + current;
                prev = temp;
                index++;
            }
            Console.WriteLine(index);
        }
    }
}
