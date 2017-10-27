using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMaxAverage
{
    class SumMinMAxAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                numbers.Add(inputNumber);
            }

            int sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avg}");



        }
    }
}
