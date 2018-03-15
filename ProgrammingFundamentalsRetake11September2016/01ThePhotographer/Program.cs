using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ThePhotographer
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            double FF = double.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling((N * FF) / 100);
            double filterTime = N * FT;
            double uploadTime = (long)(filteredPictures * UT);

            //decimal result = (filterTime + uploadTime);
            //TimeSpan ts = TimeSpan.FromSeconds(Decimal.ToDouble(result));
            // decimal day = ts.Days;

            //Console.WriteLine($"{day}:{ts}");
            Console.WriteLine(
                         TimeSpan.FromSeconds(filterTime + uploadTime)
                                .ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
        }
    }
}
