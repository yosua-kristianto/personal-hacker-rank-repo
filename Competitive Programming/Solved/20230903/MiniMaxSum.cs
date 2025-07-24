
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

namespace MiniMaxSum;

class Result
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void miniMaxSum(List<int> arr)
    {
        // Appearently can't do "where 2, and sum 2" times, so ya
        long sumMax = 0;
        long sumMin = 0;

        arr.Sort();

        // Doing it by index
        for (int i = 0; i < arr.Count; i++)
        {
            if (i == 0)
            {
                sumMin += arr[i];
            }
            else if (i == arr.Count - 1)
            {
                sumMax += arr[i];
            }
            else
            {
                sumMin += arr[i];
                sumMax += arr[i];
            }
        }

        Console.WriteLine($"{sumMin} {sumMax}");
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}
