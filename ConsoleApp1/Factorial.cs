using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Factorial
    {
        public void FindFactorial()
        {
            double result = 1;
            int increaser = 0;
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i > 0; i--)
            {
                result = result * (input - increaser);
                increaser++;
            }
            Console.WriteLine((result.ToString("F99").TrimEnd('0')).TrimEnd('.'));
            Console.WriteLine("Do you want to repeat?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                new Factorial().FindFactorial();
            }
        }

    }
}
