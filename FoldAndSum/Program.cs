using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var firstNums = numbers.Take(k).Reverse().ToArray();
            var lastNums = numbers.Reverse().Take(k).ToArray();

            var firstLine = firstNums.Concat(lastNums).ToArray();
            var secondLine = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = 0;
            for (int i = 0; i < firstLine.Length; i++)
            {
                sum = firstLine[i] + secondLine[i];
                Console.Write(sum+ " ");
            }
                Console.WriteLine();

        }
    }
}
