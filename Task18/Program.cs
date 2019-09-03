using System;
using System.IO;
using System.Linq;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = File.ReadAllLines("Triangle.txt")
                .Select(l => l.Split(' ')
                .Select(s => int.Parse(s)).ToArray())
                .Reverse().ToArray();
            for (int i = 1; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i - 1].Length - 1; j++)
                {
                    triangle[i][j] += Math.Max(triangle[i - 1][j], triangle[i - 1][j + 1]);
                }
            }
            Console.WriteLine(triangle.Last().Last());
        }
    }
}
