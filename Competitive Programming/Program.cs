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
using System.Reflection.Metadata.Ecma335;

class Result
{

  /*
   * Complete the 'breakingRecords' function below.
   *
   * The function is expected to return an INTEGER_ARRAY.
   * The function accepts INTEGER_ARRAY scores as parameter.
   */

  public static List<int> breakingRecords(List<Int64> scores)
  {
    // Flags to determine whatever the minimum or maximum score appeared
    Int64 minimum = 0;
    Int64 maximum = 0;

    // @var result
    // This variable introduced to store the flag of Min and Max as requested in the "breaking best and worst records problem.
    // The value contained within this variable is consist of this value below:
    // [0] => Max ; [1] => Min
    List<int> result = new List<int> { 0, 0 };

    // Mark the first initialization
    bool first = true;

    // Loop for everything in scores
    scores.ForEach(e =>
    { 
      // The initialization phase if minimum and maximum are 0
      if(minimum == 0 && maximum == 0 && first) 
      {
        minimum = e;
        maximum = e;
        first = false;
        return;
      }

      if (minimum > e)
      {
        minimum = e;
        result[1]++;
        return;
      }

      if (maximum < e)
      {
        maximum = e;
        result[0]++;
        return;
      }
    });

    return result;
  }

}

class Solution
{
  public static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    int n = Convert.ToInt32(Console.ReadLine().Trim());

    List<Int64> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt64(scoresTemp)).ToList();

    List<int> result = Result.breakingRecords(scores);

    textWriter.WriteLine(String.Join(" ", result));

    textWriter.Flush();
    textWriter.Close();
  }
}
