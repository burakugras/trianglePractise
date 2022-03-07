using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the base length of triangle:");
            int baseSide = int.Parse(Console.ReadLine());
            triangle(baseSide);

            Console.ReadLine();
        }
        static void triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
