using System;
using System.Collections.Generic;
using System.Linq;


namespace ShortWordsSorted
{
    class ShortWordSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower()
                .Split(new string[]
                {".", ",", ":", ";", "(", ")","[", "]", " ",", ", "'", "\\", "/", "!", "?"}
                , StringSplitOptions.RemoveEmptyEntries)
                .Where(t => t.Length < 5)
                .OrderBy(t => t)
                .Distinct()
                .ToArray();

            Console.WriteLine(String.Join(", ",text));
        }
    }
}
