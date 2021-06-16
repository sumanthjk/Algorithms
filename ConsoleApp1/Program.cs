using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reversing two words
            //Console.WriteLine("Please Type anything of your choice");
            //string para = Console.ReadLine();
            ////Reversing two words set
            //var reversingWords = new ParagraphTwoWordsReversing();
            //Console.WriteLine(reversingWords.ReverseWords(para)); 
            #endregion

            #region DiagonalMatrix
            //var matrix = new DiagonalMatrix();
            //matrix.AddSumofDiagonalElements(); 
            #endregion

            #region PlusMinus
            //var plusMinus = new PlusMinus();
            //plusMinus.CalculateTheRatios(); 
            #endregion

            #region StairCase
            //var stairCase = new StairCase();
            //stairCase.BuildStairCase();
            #endregion
            #region MiniMaxSum
            //var miniMax = new MinMaxSum();
            //miniMax.CalculateMinMax();
            #endregion
            #region BirthdayCandles
            //var birthday = new BirthdayCakeCandles();
            //birthday.Calculate();
            #endregion
            #region TimeConversion
            //new TimeConversion().ConvertTime();
            #endregion
            #region Factorial
            new Factorial().FindFactorial();
            #endregion
            Console.ReadLine();
        }
    }
}
