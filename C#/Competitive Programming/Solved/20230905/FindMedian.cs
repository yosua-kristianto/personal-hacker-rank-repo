namespace FindMedian
{
  class Result
  {

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     * This test was taken as a Mock Test. 
     * 
     * The problem was:
     * 
     * STDIN 1: The size of the array
     * STDIN 2: The array content
     * 
     * Find the median within sorted array content. 
     */

    public static int findMedian(List<int> arr)
    {
      arr.Sort();

      return arr[arr.Count / 2];
    }

  }

  class Solution
  {
    public static void FindMedians(string[] args)
    {
      // Comment this to run it through your local
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int n = Convert.ToInt32(Console.ReadLine().Trim());

      List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

      int result = Result.findMedian(arr);
      Console.WriteLine(result);

      // Comment this to run it through your local
      textWriter.WriteLine(result);
      textWriter.Flush();
      textWriter.Close();
    }
  }
}