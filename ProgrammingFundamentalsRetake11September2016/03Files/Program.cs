using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Files
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, string>> dicSaveRootAndExtension =
                new Dictionary<string, Dictionary<string, string>>();
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] inputSplit = inputLine.Split(new char[] { '\\' }
                                        , StringSplitOptions
                                        .RemoveEmptyEntries);
                string root = inputSplit[0];
                Array.Reverse(inputSplit);
                string fileNameAndExtension = inputSplit[0];

                string[] splitFilelenght = fileNameAndExtension.Split(';');
                string fileNameLenght = splitFilelenght[0];
                string size = splitFilelenght[1];

                if (!dicSaveRootAndExtension.ContainsKey(root))
                {
                    dicSaveRootAndExtension.Add(root, new Dictionary<string, string>());
                    dicSaveRootAndExtension[root][fileNameLenght] = size;
                }
                else
                {

                    dicSaveRootAndExtension[root][fileNameLenght] = size;
                }
            }
            string[] endLine = Console.ReadLine().Split(new char[] { ' ' }
                                                , StringSplitOptions
                                                .RemoveEmptyEntries);
            string extensionSearch = endLine[0];
            string rootSearch = endLine[2];

            Dictionary<string, string> dicFinish = new Dictionary<string, string>();
            foreach (var root in dicSaveRootAndExtension)
            {
                if (rootSearch == root.Key)
                {
                    foreach (var value in root.Value)
                    {
                        int lastIndex = value.Key.LastIndexOf('.');
                        string tempExten = value.Key.Substring(lastIndex + 1);

                        if (extensionSearch == tempExten)
                        {
                            if (!dicFinish.ContainsKey(value.Key))
                            {
                                dicFinish.Add(value.Key, null);
                                dicFinish[value.Key] = value.Value;
                            }
                        }
                    }
                }
            }
            if (dicFinish.Count == 0)
            {
                Console.WriteLine("No");
            }
            Console.WriteLine();
            foreach (var item in dicFinish.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value} KB ");
            }
        }
    }
}
