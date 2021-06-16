using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class ParagraphTwoWordsReversing
    {
        int i = 0;
        public string ReverseWords(string para)
        {
            string[] array = para.Split(" ").ToArray();
            string a = null;
            //List<string> result = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in array)
            {
                i++;
                if (i == 1)
                {
                    a = item;
                }
                else if (i == 2)
                {
                    string b = item;
                    stringBuilder.Append(b + " " + a + " ");
                    //result.Add(b + " " + a + " ");
                    i = 0;
                }
            }
            return stringBuilder.ToString();
        }
    }
}
