namespace DivisibleSumPairs
{
    class Result
    {

        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         *  
         *  To make it simple, this function supposed to search pair of number within ar, where if they are sum, it must be divisible by k.
         *  The math operation must be done from index 0 to n. So there must no any ar[5] + ar[4] stuffs. If 5 is i and 4 is j, then I can say, the i must be lesser than j.
         *  The output is the count of pairs that available.
         */

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            // Flag count of pairs that available.
            int pairs = 0;

            // Loop every value within ar
            for (int i = 0; i < ar.Count; i++)
            {
                // Starting from the next of current selected value to be sum with
                for (int j = i + 1; j < ar.Count; j++)
                {
                    // If ar[i] sum with ar[j] is divisible with k, then add 1 to pairs var.
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        pairs++;
                    }
                }
            }

            return pairs;
        }

    }

    class Solution
    {
        public static void DivisibleSumPairs(string[] args)
        {
            // Comment this when running in your local
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.divisibleSumPairs(n, k, ar);

            // Comment this when running in your local
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }

}

