using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class DiagonalMatrix
    {
        public void AddSumofDiagonalElements()
        {
            int j = 0;
            int k = 0;
            int l = 0;
            StringBuilder stringBuilder = new StringBuilder();
            Console.Write("Enter the size of array:");
            var size = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"Enter {i+1} row of {size} elements.");
                stringBuilder.Append(Console.ReadLine().Trim() + "s");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            var split = stringBuilder.ToString().Split("s");
            foreach(var item in split)
            {
                j++;
                var splite = item.Split(" ");
                k = k + int.Parse(splite[j-1]);
                l = l + int.Parse(splite[size - j]);
            }
            int res = 0;
            if (k > l)
            {
                res = k - l;
            }
            else
            {
                res = l - k;
            }
            var max = Math.Max(k,l);
            var min = Math.Min(k,l);
            Console.WriteLine($"The sum of the diagonals is {Math.Abs(k-l)}");
            Console.WriteLine($"Conventional : {max - min}");
            Console.WriteLine($"{res}");

        }
    }
}
