using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StairCase
    {
        public void BuildStairCase()
        {
            int s = 0;
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                s++;
                for (int l = size - s; l > 0; l--)
                {
                    Console.Write(' ');
                }
                for (int z = 0; z < s; z++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
                //changes made to the file
            }
        }
    }
}
