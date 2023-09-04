namespace SparseArrays
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         *  
         *  To simplify, this problem is searching text within strings by quering within queries in precise technique. (Not using %LIKE%).
         *  The expected return is the list of count number that came from queries.
         *  @link https://www.hackerrank.com/challenges/three-month-preparation-kit-sparse-arrays/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
         */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> foundCount = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {
                int currentQueryFoundCount = 0;
                string e = queries[i];

                foreach (string str in strings)
                {
                    if (str.Equals(e))
                    {
                        currentQueryFoundCount++;
                    }
                }

                foundCount.Add(currentQueryFoundCount);
            }

            return foundCount;
        }

    }

    class Solution
    {
        public static void sparseArray(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(strings, queries);

            textWriter.WriteLine(String.Join("\n", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
