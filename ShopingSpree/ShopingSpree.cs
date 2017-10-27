using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingSpree
{
    class ShopingSpree
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> basket = new Dictionary<string, List<double>>();

            double budget = double.Parse(Console.ReadLine());
            string inputProduct = Console.ReadLine();

            while (inputProduct != "end")
            {
                var productData = inputProduct.Split(' ').ToArray();
                string productName = productData[0];
                double productPrice = double.Parse(productData[1]);
                if (!basket.ContainsKey(productName))
                {
                    basket.Add(productName, new List<double>());
                }
                basket[productName].Add(productPrice);
                inputProduct = Console.ReadLine();
            }

            Dictionary<string, double> newBasket = new Dictionary<string, double>();

            double sum = 0;
            foreach (var product in basket)
            {
                sum += product.Value.Min();
                newBasket[product.Key] = product.Value.Min();
            }

            var readyBasket = newBasket
               .OrderByDescending(n => n.Value)
               .ThenByDescending(b => b.Key)
               .ToDictionary(b => b.Key, b => b.Value);



            if (sum <= budget)
            {
                foreach (var element in readyBasket)
                {
                    Console.WriteLine($"{element.Key} costs {element.Value:f2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }

        }
    }
}
