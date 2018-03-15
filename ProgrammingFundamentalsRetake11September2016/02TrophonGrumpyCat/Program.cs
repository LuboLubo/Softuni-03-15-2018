using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02TrophonGrumpyCat
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                                        .Split(new char[] { ' ' }
                                        , StringSplitOptions
                                        .RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();
            int entryIndex = int.Parse(Console.ReadLine());

            string commandFirst = Console.ReadLine();
            string commandSecond = Console.ReadLine();

            long sumLeft = 0;
            long sumRight = 0;
            if (commandFirst.Equals("expensive"))
            {
                InsertResultExpensive(numbers, entryIndex, commandSecond, ref sumLeft, ref sumRight);
            }
            else if (commandFirst.Equals("cheap"))
            {
                InsertResultCheap(numbers, entryIndex, commandSecond, ref sumLeft, ref sumRight);
            }
            if (sumLeft > sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if (sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else
            {
                Console.WriteLine($"Left - {sumLeft}");
            }

        }

        private static void InsertResultCheap(int[] numbers, int entryIndex, string commandSecond, ref long sumLeft, ref long sumRight)
        {
            if (commandSecond.Equals("positive"))
            {
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] < index && numbers[i] > 0)
                    {
                        sumLeft += numbers[i];
                    }
                }
                // result right
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] < index && numbers[i] > 0)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
            else if (commandSecond.Equals("negative"))
            {
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] < index && numbers[i] < 0)
                    {
                        sumLeft += numbers[i];
                    }
                }
                // result right
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] < index && numbers[i] < 0)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
            if (commandSecond.Equals("all"))
            {
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] < index)
                    {
                        sumLeft += numbers[i];
                    }
                }
                // result right
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] < index)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
        }

        private static void InsertResultExpensive(int[] numbers, int entryIndex, string commandSecond, ref long sumLeft, ref long sumRight)
        {
            if (commandSecond.Equals("positive"))
            {
                // result left
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] >= index && numbers[i] > 0)
                    {
                        sumLeft += numbers[i];
                    }
                }
                // result right
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] >= index && numbers[i] > 0)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
            else if (commandSecond.Equals("negative"))
            {
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] >= index && numbers[i] < 0)
                    {
                        sumLeft += numbers[i];
                    }
                }
                // result right
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] >= index && numbers[i] < 0)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
            if (commandSecond.Equals("all"))
            {
                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == entryIndex)
                    {
                        index = numbers[i];
                    }
                }
                for (int i = 0; i < entryIndex; i++)
                {
                    if (numbers[i] >= index)
                    {
                        sumLeft += numbers[i];
                    }
                }
                for (int i = entryIndex; i < numbers.Length; i++)
                {
                    if (numbers[i] >= index)
                    {
                        sumRight += numbers[i];
                    }
                }
            }
        }
    }
}
