using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class PlusMinus
    {
        public void CalculateTheRatios()
        {
            int zeroes = 0;
            int positives = 0;
            int negatives = 0;
            int size = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToList();
            foreach(var i in arr)
            {
                if (i > 0)
                    positives++;
                else if (i < 0)
                    negatives++;
                else if (i == 0)
                    zeroes++;
            }
            Console.WriteLine(Decimal.Round((decimal)positives / size, 6).ToString("0.000000"));
            Console.WriteLine(Decimal.Round((decimal)negatives / size, 6).ToString("0.000000"));
            Console.WriteLine(Decimal.Round((decimal)zeroes / size, 6).ToString("0.000000"));
        }
    }
}
