using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaltValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colectionOfWords = new Dictionary<string, string>();
            string inputData = Console.ReadLine();

            while (inputData != "end")
            {
                var inputWords = inputData.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string wordsKey = inputWords[0];
                string wordsValue = inputWords[1];
                colectionOfWords[wordsKey] = wordsValue;
                inputData = Console.ReadLine();
            }
            inputData = Console.ReadLine();
            //Dictionary<string, string> colection = colectionOfWords.OrderBy(c => c.Value)
            //   .ThenBy(c => c.Key)
            //   .ToDictionary(c => c.Key, c => c.Value);
            Dictionary<string, string> colection1 = colectionOfWords
                .Where(c => (c.Value != "null"))
                .OrderBy(c => c.Value.Length)
                .Reverse()
                .ToDictionary(c => c.Key, c => c.Value);

            Dictionary<string, string> colection2 = colectionOfWords
               .Where(c => (c.Value == "null"))
               .ToDictionary(c => c.Key, c => c.Value);

            Dictionary<string, string> colection = colection1.Concat(colection2).ToDictionary(c => c.Key, c => c.Value);

            foreach (var words in colection)
            {
                if (words.Value == "null")
                {
                    Console.WriteLine($"{words.Key} <-> {inputData}");
                }
                else
                {
                    Console.WriteLine($"{words.Key} <-> {words.Value}");

                }
            }
        }
    }
}
