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
using System.Security;

namespace MiniMaxSum
{
  class Result
  {

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * MiniMaxSum
     * @link https://www.hackerrank.com/challenges/three-month-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
     */

    public static void miniMaxSum(List<Int64> arr)
    {
      Int64 minimum = 0;
      Int64 maximum = 0;

      // Loop through number within array to be excluded.
      for (int i = 0; i < arr.Count; i++)
      {
        Int64 currentSum = 0;

        // Generate sum (except for current i) for every number within array
        for (int j = 0; j < arr.Count; j++)
        {
          if (j != i)
          {
            currentSum += arr[j];
          }
        }

        // Initialize the minimium and maximum
        if (minimum == 0 && maximum == 0)
        {
          minimum = currentSum;
          maximum = currentSum;
          continue;
        }

        // Redefine Minimum
        if (minimum > currentSum)
        {
          minimum = currentSum;
          continue;
        }

        // Redefine Maximum
        if (maximum < currentSum)
        {
          maximum = currentSum;
        }
      }

      Console.WriteLine(minimum.ToString() + " " + maximum.ToString());
    }

  }

  class Solution
  {
    public static void MiniMaxSum(string[] args)
    {

      List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

      Result.miniMaxSum(arr);
    }
  }
}
