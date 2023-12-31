﻿namespace TimeConvertion
{
  class Result
  {

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     * @link https://www.hackerrank.com/challenges/three-month-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
     */

    public static string timeConversion(string s)
    {
      DateTime datetime = DateTime.Parse(s);

      string convertedDateTime = datetime.ToString("HH:mm:ss");

      return convertedDateTime;
    }

  }

  class Solution
  {
    public static void TimeConvertion(string[] args)
    {
      // Comment this when running in your local
      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      string s = Console.ReadLine();

      string result = Result.timeConversion(s);

      // Comment this when running in your local
      textWriter.WriteLine(result);
      textWriter.Flush();
      textWriter.Close();
    }
  }
}

