using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace PlusMinus;
class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void plusMinus(List<int> arr)
    {
        decimal ratioMinus = 0;
        decimal ratioPlus = 0;
        decimal ratioZero = 0;

        for (int i = 0; i < arr.Count; i++)
        {

            if (arr[i] < 0) ratioMinus++;
            if (arr[i] > 0) ratioPlus++;
            if (arr[i] == 0) ratioZero++;
        }

        decimal minus = ratioMinus / arr.Count;
        decimal plus = ratioPlus / arr.Count;
        decimal zeros = ratioZero / arr.Count;

        Console.WriteLine(plus.ToString("N6"));
        Console.WriteLine(minus.ToString("N6"));
        Console.WriteLine(zeros.ToString("N6"));
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.plusMinus(arr);
    }
}