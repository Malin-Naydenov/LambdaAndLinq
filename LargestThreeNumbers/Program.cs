using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .Take(3)
                .ToArray();

            //var numbers = inputNums.OrderByDescending(x =>x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
