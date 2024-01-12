namespace FlippingBits
{
  class Result
  {

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     * 
     * This problem makes me find the binary of the n first, and then flip the n, and then convert it into the long again.
     * 
     * Let's say 0001 -> 1110
     * Remember that the binary is 32-bit based
     */

    public static long flippingBits(long n)
    {
      // This is the data structure to store the bitmap.
      List<int> bitmapCollection = new List<int>();

      while (n > 0)
      {
        // Save the remainder to judge its bit
        long remainder = n % 2;

        // Reassign n as quotient
        n = n / 2;

        if (remainder != 0)
        {
          // This is intentional since I want to flip the result
          bitmapCollection.Add(0);
        }
        else
        {
          // This is intentional since I want to flip the result
          bitmapCollection.Add(1);
        }
      }

      // Force the bitmap collection to 32-bit
      if (bitmapCollection.Count < 32)
      {
        int pivot = bitmapCollection.Count;
        for (int i = 0; i < (32 - pivot); i++)
        {
          // This is intentional since I want to flip the result
          bitmapCollection.Add(1);
        }
      }

      // New Number
      double newLong = 0L;

      // Reverse the bitmap
      bitmapCollection.Reverse();

      // The bitmapCollection.Count must always decreased by 1 to avoid array out of range problem
      // Or, if you're a chad, you can just hard code it to 32.

      int bitmapColumnSize = (bitmapCollection.Count - 1);

      for (int i = bitmapColumnSize; i >= 0; i--)
      {
        int e = bitmapCollection[i];
        int exponent = bitmapColumnSize - i;

        if (e == 1)
        {
          // This is act as 2^exponent
          double pivot = (double)Math.Pow(2, exponent);
          newLong += pivot;
        }
      }

      return (long)newLong;
    }

  }

  class Solution
  {
    public static void FlippingBit(string[] args)
    {
      // Comment this to run in local
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int q = Convert.ToInt32(Console.ReadLine().Trim());

      for (int qItr = 0; qItr < q; qItr++)
      {
        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.flippingBits(n);

        // Comment this to run in local
        textWriter.WriteLine(result);
      }

      // Comment this to run in local
      textWriter.Flush();
      textWriter.Close();
    }
  }

}