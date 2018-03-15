using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SweetDessert
{
    class Program
    {
        static void Main()
        {
            double amountCash = double.Parse(Console.ReadLine());
            double numberQuests = double.Parse(Console.ReadLine());
            double priceBanana = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());

            Console.WriteLine();
            double resultQuests = Math.Ceiling(numberQuests / 6);
            Console.WriteLine();
            double resultProduct = (resultQuests * (2 * priceBanana)) + (resultQuests * (4 * priceEggs))
                                    + (resultQuests * (0.2 * priceBerries));
            Console.WriteLine();
            if (resultProduct <= amountCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", resultProduct);
            }
            else if (resultProduct > amountCash)
            {
                resultProduct = resultProduct - amountCash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", resultProduct);
            }
        }
    }
}
