using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var inputTokens = input.Split(' ');

                if (inputTokens[0] == "flatten")
                {
                    string keyToFlattened = inputTokens[1];
                    data[keyToFlattened] = data[keyToFlattened].ToDictionary(k => k.Key + k.Value, k => "flattened");
                }
                else
                {
                    string key = inputTokens[0];
                    string innerKey = inputTokens[1];
                    string innerValue = inputTokens[2];

                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }

                    data[key][innerKey] = innerValue;

                }

                input = Console.ReadLine();
            }

            var orderedData = data.OrderByDescending(d => d.Key.Length).ToDictionary(d => d.Key, d => d.Value);

            foreach (var key in orderedData)
            {
                string topKey = key.Key;
                var keyValue = key.Value;

                Console.WriteLine("{0}", topKey);

                var unflattened = keyValue
                        .Where(k => k.Value != "flattened")
                        .OrderBy(k => k.Key.Length);

                var flattened = keyValue.Where(k => k.Value == "flattened");

                int count = 1;
                foreach (var elements in unflattened)
                {
                    string prod = elements.Key;
                    string prod2 = elements.Value;
                    Console.WriteLine($"{count}. {prod} - {prod2}");
                    count++;
                }
                foreach (var item in flattened)
                {
                    Console.WriteLine($"{count}. {item.Key}");
                    count++;
                }

            }
        }
    }
}
