namespace LonelyInteger
{
    class Result
    {

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         * @link https://www.hackerrank.com/challenges/three-month-preparation-kit-lonely-integer/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-two
         */

        public static int lonelyinteger(List<int> a)
        {
            // This is a data structure to store whatever non-unique value found.
            List<int> nonUniqueFound = new List<int>();

            for (int i = 0; i < (a.Count); i++)
            {
                bool foundFlag = false;

                // If current loop has a number that already stored in nonUniqueFound, skip this loop.
                if (nonUniqueFound.Contains(a[i]))
                {
                    continue;
                }

                // Loop through series starting from i+1
                for (int j = i + 1; j < a.Count; j++)
                {
                    // If the series is same as a[i], then set the foundFlag to true, and store the value to nonUniqueValue
                    if (a[i] == a[j])
                    {
                        foundFlag = true;
                        nonUniqueFound.Add(a[i]);
                        break;
                    }
                }

                if (!foundFlag)
                {
                    Console.WriteLine(a[i]);
                    return a[i];
                }
            }

            throw new Exception("There are no unique number within the array series.");
        }
    }

    class Solution
    {
        public static void LonelyIntegers(string[] args)
        {
            // Comment this to run in local
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.lonelyinteger(a);

            // Comment this to run in local
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }

}
