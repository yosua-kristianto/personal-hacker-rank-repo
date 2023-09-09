namespace Pangram
{
    class Result
    {

        /*
         * Complete the 'pangrams' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string pangrams(string s)
        {
            // Whatever any letter not found in from the text, return not pangram.
            foreach (char e in "abcdefghijklmnopqrstuvwyxz")
            {
                if (!s.ToLower().Contains(e))
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }

    }

    class Solution
    {
        public static void Pangrams(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.pangrams(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}