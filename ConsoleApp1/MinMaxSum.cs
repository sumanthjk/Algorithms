using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MinMaxSum
    {
        public void CalculateMinMax()
        {
            var input = Console.ReadLine().Split(' ').Select(a => Convert.ToInt64(a)).ToList();
            //var max = input.Max();
            //var min = input.Min();
            //var minValues  = new List<long>();
            //minValues.AddRange(input);
            //minValues.Remove(min);
            //var maxValues = new List<long>();
            //maxValues.AddRange(input);
            //maxValues.Remove(max);
            //Console.WriteLine(maxValues.Sum() + " " + minValues.Sum());
            var sum = input.Sum();
            Console.WriteLine($"{sum - input.Min()} {sum - input.Max()}");

        }
    }
}
