namespace CountingSorts
{
  class Result
  {
    private static List<int> testCase = new List<int> { 0, 2, 0, 2, 0, 0, 1, 0, 1, 2, 1, 0, 1, 1, 0, 0, 2, 0, 1, 0, 1, 2, 1, 1, 1, 3, 0, 2, 0, 0, 2, 0, 3, 3, 1, 0, 0, 0, 0, 2, 2, 1, 1, 1, 2, 0, 2, 0, 1, 0, 1, 0, 0, 1, 0, 0, 2, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 2, 1, 3, 2, 0, 0, 2, 1, 2, 1, 0, 2, 2, 1, 2, 1, 2, 1, 1, 2, 2, 0, 3, 2, 1, 1, 0, 1, 1, 1, 0, 2, 2 };

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     * 
     * Technically this case wanted me to count every appereances of values within an array where the values are 0 <= x < 100
     * 
     * 
     * Test case input:
     * 
     * 63 25 73  1 98 73 56 84 86 57 16 83
     *  8 25 81 56  9 53 98 67 99 12 83 89 
     * 80 91 39 86 76 85 74 39 25 90 59 10 
     * 94 32 44  3 89 30 27 79 46 96 27 32 
     * 18 21 92 69 81 40 40 34 68 78 24 87 
     * 42 69 23 41 78 22  6 90 99 89 50 30 
     * 20  1 43  3 70 95 33 46 44  9 69 48 
     * 33 60 65 16 82 67 61 32 21 79 75 75 
     * 13 87 70 33
     * 
     * The expected result is in the testCase.
     */

    public static List<int> countingSort(List<int> arr)
    {
      // Speaking about array, it has [index] and value components. The array index will treated as the number
      // that represent coeficient within the input while its value is storing its coeficient's appearances
      List<int> countingArray = new List<int>();

      // Initialize countingArray from index 0 to 99 by 0.
      for (int i = 0; i < 100; i++)
      {
        countingArray.Add(0);
      }

      foreach (int i in arr)
      {
        countingArray[i] = countingArray[i] + 1;
      }

      // You can delete this statement since it meant for testing.
      for (int i = 0; i < countingArray.Count; i++)
      {
        Console.WriteLine("Index of [" + i + "] counted: " + countingArray[i] + " the expected test is " + testCase[i]);
      }

      return countingArray;
    }

  }

  class Solution
  {
    public static void CountingSort(string[] args)
    {
      // Comment this to run in your local.
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int n = Convert.ToInt32(Console.ReadLine().Trim());

      List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

      List<int> result = Result.countingSort(arr);

      // Comment this to run in your local.
      textWriter.WriteLine(String.Join(" ", result));
      textWriter.Flush();
      textWriter.Close();
    }
  }

}