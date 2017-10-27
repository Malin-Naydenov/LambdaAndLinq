using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>
            {
                1, 5, 2, 4, 3
            };

            List<int> test = nums.OrderByDescending(t => t).ToList();

            Console.WriteLine(String.Join(" ", test));
        }
    }
}
