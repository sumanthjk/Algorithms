using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class BirthdayCakeCandles
    {
        public void Calculate()
        {
            int i = 1;
            var size = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToList();
            //var count = array.Where(a=>a == array.Max()).Count();
            var max = array.Max();
            Console.WriteLine(array.Count(a => a == max));
            //array.Remove(max);
            //foreach(var item in array)
            //{
            //    if (item == max)
            //        i += 1;
            //}
            //Console.WriteLine(i);
        }
    }
}
