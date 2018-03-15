using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {
            int numbersGrup = int.Parse(Console.ReadLine());

            int resultMonth = 0;
            List<decimal> list = new List<decimal>();
            List<decimal> sumNum = new List<decimal>();
            for (int i = 0; i < numbersGrup; i++)
            {
                resultMonth = 0;
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy"
                                    , CultureInfo.InvariantCulture);
                long secondNum = long.Parse(Console.ReadLine());

                decimal priceResult = DateTime.DaysInMonth(date.Year, date.Month) * secondNum * price;
                Console.WriteLine("The price for the coffee is: ${0:F2}", priceResult);
                list.Add(priceResult);
            }

            decimal finishSum = 0;
            foreach (var number in list)
            {
                finishSum = number + finishSum;
            }
            Console.WriteLine("Total: ${0:F2}", finishSum);
        }
    }
}
