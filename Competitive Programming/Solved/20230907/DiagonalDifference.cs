namespace DiagonalDifferences
{
  class Result
  {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     * 
     * This problem can be solved by determining square matrix.
     * 
     * Hence a matrix of 
     * 
     * 1 2 3
     * 4 5 6
     * 7 8 9
     * 
     * We will go for | (1 + 5 + 9) - (3 + 5 + 7) | = |(0)| = 0
     * Absoluting the result, resulting the number cannot be less than 0.
     * 
     * (0, 0) + (1, 1) + (2, 2)
     * Minus
     * (0, 2) + (1, 1) + (2, 0)
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
      // Upper Left to Right Bottom 
      int x1 = 0;
      for (int i = 0; i < arr.Count; i++)
      {
        x1 += arr[i][i];
      }

      // Upper Right to Left Bottom
      int x2 = 0;
      for (int i = 0; i < arr.Count; i++)
      {
        x2 += arr[i][((arr.Count - 1) - i)];
      }

      return Math.Abs(x1 - x2);
    }

  }

  class Solution
  {
    public static void DiagonalDifferences(string[] args)
    {
      // Comment this to run in local. I'm not debug this in local tho'.
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int n = Convert.ToInt32(Console.ReadLine().Trim());

      List<List<int>> arr = new List<List<int>>();

      for (int i = 0; i < n; i++)
      {
        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
      }

      int result = Result.diagonalDifference(arr);

      // Comment this to run in local. I'm not debug this in local tho'.
      textWriter.WriteLine(result);
      textWriter.Flush();
      textWriter.Close();
    }
  }

}