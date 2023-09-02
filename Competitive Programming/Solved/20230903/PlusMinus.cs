namespace PlusMinus 
{
  class Result
  {

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     * Hacker Rank 
     * @link https://www.hackerrank.com/challenges/three-month-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
     */

    public static void plusMinus(List<int> arr)
    {
      int plus = 0;
      int minus = 0;
      int zero = 0;

      arr.ForEach(x =>
      {
        if (x > 0)
        {
          plus++;
        }
        else if (x < 0)
        {
          minus++;
        }
        else
        {
          zero++;
        }
      });

      int[] flags = { plus, minus, zero };

      foreach (int i in flags)
      {
        double value = (double)i / (double)arr.Count();
        Console.WriteLine(value.ToString("F6").Replace(",", "."));
      }
    }

  }

  class Solution
  {
    public static void PlusMinus(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine().Trim());

      List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

      Result.plusMinus(arr);
    }
  }

}
