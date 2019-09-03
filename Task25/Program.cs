using System;
using System.Collections.Generic;
using System.Numerics;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<BigInteger>
            {
                1, 1
            };
            for (int i = 2; list[list.Count - 1].ToString().Length < 1000; i++)
            {
                list.Add(list[i - 1] + list[i - 2]);
            }
            Console.WriteLine(list.Count);
        }
    }
}
