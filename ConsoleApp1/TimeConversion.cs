using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TimeConversion
    {
        public void ConvertTime()
        {
            var time = Console.ReadLine().ToLower().Split(':').ToArray();
            if (time[2].Contains("pm"))
            {
                if (int.Parse(time[0]) != 12)
                    time[0] = (int.Parse(time[0].ToString()) + 12).ToString();
                time[2] = time[2].Remove(2);
            }
            else
            {
                if (int.Parse(time[0]) == 12)
                    time[0] = "00";
                time[2] = time[2].Remove(2);
            }
            Console.WriteLine(time[0] + ':' + time[1] + ':' + time[2]);
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dateTime.ToString("HH:mm:ss"));
        }
    }
}
