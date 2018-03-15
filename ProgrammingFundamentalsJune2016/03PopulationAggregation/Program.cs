using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PopulationAggregation
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<long>>> dic = new Dictionary<string, Dictionary<string, List<long>>>();
            string inputLine = Console.ReadLine();
            bool IsDublicateCity = false;
            while (!inputLine.Equals("stop"))
            { 
                string[] inputSplit = inputLine.Split(new char[] { '\\', ' ' }
                                        , StringSplitOptions
                                        .RemoveEmptyEntries);

                string firstWord = inputSplit[0];
                string secondWord = inputSplit[1];

                long population = long.Parse(inputSplit[2]);

                string firstLetter = firstWord.Substring(0, 1);
                string secondLetter = secondWord.Substring(0, 1);

                char firstChar = char.Parse(firstLetter);
                char secondChar = char.Parse(secondLetter);

                if (firstChar >= 'A' && firstChar <= 'Z')
                {
                    //revision country
                    string[] firstWordSplit = firstWord.Split('@', '#', '$', '&', '1',
                                                                '2', '3', '4', '5', '6',
                                                                '7', '8', '9', '0');
                    string country = "";
                    foreach (var item in firstWordSplit)
                    {
                        country += item;
                    }
                    // revision City
                    string[] secondWordSplit = secondWord.Split('@', '#', '$', '&', '1',
                                                                '2', '3', '4', '5', '6',
                                                                '7', '8', '9', '0');
                    string city = "";

                    foreach (var item in secondWordSplit)
                    {
                        city += item;
                    }

                    if (!dic.ContainsKey(country))
                    {
                        dic.Add(country, new Dictionary<string, List<long>>());
                        dic[country][city] = new List<long>();
                        dic[country][city].Add(population);
                    }
                    else
                    {
                        if (!dic[country].ContainsKey(city))
                        {
                            dic[country][city] = new List<long>();
                            dic[country][city].Add(population);
                        }
                        else
                        {
                            dic[country][city].Add(population);
                            IsDublicateCity = true;
                        }
                    }
                }
                else
                {
                    // revison city
                    string[] firstWordSplit = firstWord.Split('@', '#', '$', '&', '1',
                                                               '2', '3', '4', '5', '6',
                                                               '7', '8', '9', '0');
                    string city = "";

                    foreach (var item in firstWordSplit)
                    {
                        city += item;
                    }
                    // revision country
                    string[] secondWordSplit = secondWord.Split('@', '#', '$', '&', '1',
                                                                    '2', '3', '4', '5', '6',
                                                                    '7', '8', '9', '0');
                    string country = "";
                    foreach (var item in secondWordSplit)
                    {
                        country += item;
                    }

                    if (!dic.ContainsKey(country))
                    {
                        dic.Add(country, new Dictionary<string, List<long>>());
                        dic[country][city] = new List<long>();
                        dic[country][city].Add(population);
                    }
                    else
                    {
                        if (!dic[country].ContainsKey(city))
                        {
                            dic[country][city] = new List<long>();
                            dic[country][city].Add(population);
                        }
                        else
                        {
                            dic[country][city].Add(population);
                            IsDublicateCity = true;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var country in dic.OrderBy(country => country.Key))
            {
                if (IsDublicateCity == true)
                {
                    int lenght = 0;
                    foreach (var item in country.Value)
                    {
                        lenght = item.Value.Count;
                        break;
                    }
                    Console.WriteLine($"{country.Key} -> {lenght}");
                }
                else
                {
                    Console.WriteLine($"{country.Key} -> {country.Value.Count}");
                }
            }
            Dictionary<string, long> dicCity = new Dictionary<string, long>();

            foreach (var item in dic.Values)
            {
                foreach (var ite in item)
                {
                    if (!dicCity.ContainsKey(ite.Key))
                    {
                        dicCity.Add(ite.Key, 0);
                        foreach (var it in ite.Value)
                        {
                            dicCity[ite.Key] = it;
                        }
                    }
                }
            }
            foreach (var item in dicCity.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
