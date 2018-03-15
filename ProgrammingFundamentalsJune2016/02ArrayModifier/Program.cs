using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayModifier
{
    class Program
    {
        static void Main()
        {
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] inputTokens = command.Split(' ');
                string commandAction = inputTokens[0];

                switch (commandAction)
                {
                    case "swap":
                        string first = inputTokens[1];
                        string second = inputTokens[2];
                        int index1 = int.Parse(first);
                        int index2 = int.Parse(second);
                        long temp = input[index1];
                        input[index1] = input[index2];
                        input[index2] = temp;
                        break;
                    case "multiply":
                        string firstm = inputTokens[1];
                        string secondm = inputTokens[2];
                        int index1m = int.Parse(firstm);
                        int index2m = int.Parse(secondm);
                        input[index1m] = input[index1m] * input[index2m];
                        break;
                    case "decrease":
                        input = Array.ConvertAll(input, x => x - 1);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
